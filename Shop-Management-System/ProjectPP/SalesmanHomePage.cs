using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class SalesmanHomePage : Form
    {
        private string _salesmanName;
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public SalesmanHomePage(string salesmanName)
        {
            InitializeComponent();
            _salesmanName = salesmanName;
        }

        private void SalesmanHomePage_Load(object sender, EventArgs e)
        {
            lblWelcomeUser.Text = "👨‍💼 Welcome, " + _salesmanName;
            LoadProductsFromDatabase();
        }

        private void LoadProductsFromDatabase(string categoryFilter = null, string searchTerm = null)
        {
            pnlBody.Controls.Clear();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    var queryBuilder = new StringBuilder("SELECT * FROM Product_Details");
                    var conditions = new List<string>();

                    if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter.ToUpper() != "ALL")
                        conditions.Add("Product_type = @Category");

                    if (!string.IsNullOrEmpty(searchTerm))
                        conditions.Add("(Model LIKE @SearchTerm OR Brand_name LIKE @SearchTerm)");

                    if (conditions.Count > 0)
                        queryBuilder.Append(" WHERE " + string.Join(" AND ", conditions));

                    using (SqlCommand sqlCmd = new SqlCommand(queryBuilder.ToString(), sqlCon))
                    {
                        if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter.ToUpper() != "ALL")
                            sqlCmd.Parameters.AddWithValue("@Category", categoryFilter);

                        if (!string.IsNullOrEmpty(searchTerm))
                            sqlCmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Label noProductsLabel = new Label
                                {
                                    Text = "No products found.",
                                    Font = new Font("Segoe UI", 14F),
                                    ForeColor = Color.Gray,
                                    AutoSize = false,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Size = pnlBody.Size
                                };
                                pnlBody.Controls.Add(noProductsLabel);
                                return;
                            }

                            while (reader.Read())
                            {
                                // Get available quantity safely
                                int availableQty = 0;
                                if (!(reader["Available_Product"] is DBNull))
                                    availableQty = Convert.ToInt32(reader["Available_Product"]);

                                pnlBody.Controls.Add(CreateProductCard(
                                    reader["Product_code"].ToString(),
                                    reader["Image"] as byte[],
                                    reader["Model"].ToString(),
                                    reader["Current_Price"] is DBNull ? 0 : Convert.ToDecimal(reader["Current_Price"]),
                                    reader["Regular_Price"] is DBNull ? 0 : Convert.ToDecimal(reader["Regular_Price"]),
                                    reader["Status"].ToString(),
                                    reader["Brand_name"].ToString(),
                                    reader["Key_Features"].ToString(),
                                    reader["Product_type"].ToString(),
                                    availableQty
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products. Error: " + ex.Message, "Database Error");
            }
        }

        private Panel CreateProductCard(string productCode, byte[] imageData, string model, decimal currentPrice, decimal regularPrice, string status, string brand, string keyFeatures, string productType, int availableQty)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 380,
                BackColor = Color.White,
                Margin = new Padding(15),
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox pic = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 150,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                    pic.Image = Image.FromStream(ms);
            }
            else
            {
                pic.BackColor = Color.Gainsboro;
            }

            Label brandLabel = new Label
            {
                Text = brand,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                Dock = DockStyle.Top,
                Padding = new Padding(10, 5, 10, 0),
                Height = 30
            };
            Label nameLabel = new Label
            {
                Text = model,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Padding = new Padding(10, 0, 10, 5),
                Height = 55
            };
            Label statusLabel = new Label
            {
                Text = status,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Padding = new Padding(10, 0, 10, 5),
                Height = 30,
                ForeColor = status.ToLower() == "in stock" ? Color.Green : Color.Red
            };

            Panel pricePanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(10, 0, 10, 0)
            };
            Label currentPriceLabel = new Label
            {
                Text = "৳" + currentPrice.ToString("N0"),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 123, 255),
                Dock = DockStyle.Left,
                AutoSize = true
            };
            Label regularPriceLabel = new Label
            {
                Text = "৳" + regularPrice.ToString("N0"),
                Font = new Font("Segoe UI", 10F, FontStyle.Strikeout),
                ForeColor = Color.Gray,
                Dock = DockStyle.Left,
                AutoSize = true,
                Padding = new Padding(10, 3, 0, 0)
            };
            pricePanel.Controls.Add(regularPriceLabel);
            pricePanel.Controls.Add(currentPriceLabel);

            FlowLayoutPanel actionsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                Padding = new Padding(5),
                FlowDirection = FlowDirection.LeftToRight
            };
            LinkLabel detailsLink = new LinkLabel
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 10F),
                LinkColor = Color.DodgerBlue,
                Margin = new Padding(5, 10, 20, 10),
                AutoSize = true,
                TabStop = false
            };
            detailsLink.LinkClicked += (s, e) =>
            {
                MessageBox.Show(keyFeatures, "Key Features: " + model);
            };

            Button sellButton = new Button
            {
                Text = "Sell",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.OrangeRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 35)
            };
            sellButton.FlatAppearance.BorderSize = 0;
            sellButton.Click += (s, e) =>
            {
                SellItem sellForm = new SellItem(imageData, model, currentPrice, productCode, productType, keyFeatures, availableQty);
                sellForm.ShowDialog(this);
            };

            actionsPanel.Controls.Add(detailsLink);
            actionsPanel.Controls.Add(sellButton);

            card.Controls.Add(actionsPanel);
            card.Controls.Add(pricePanel);
            card.Controls.Add(statusLabel);
            card.Controls.Add(nameLabel);
            card.Controls.Add(brandLabel);
            card.Controls.Add(pic);

            return card;
        }

        private void lblShopName_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search Products...";
            txtSearch.ForeColor = Color.Gray;
            LoadProductsFromDatabase();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string category = clickedButton.Text;
                txtSearch.Text = "Search Products...";
                txtSearch.ForeColor = Color.Gray;
                LoadProductsFromDatabase(category == "ALL" ? null : category);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search Products...")
            {
                LoadProductsFromDatabase(null, txtSearch.Text);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Products...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Products...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Focused && txtSearch.Text != "Search Products...")
            {
                LoadProductsFromDatabase(null, txtSearch.Text);
            }
        }

        private void lblWelcomeUser_Click(object sender, EventArgs e)
        {

        }
    }
}
