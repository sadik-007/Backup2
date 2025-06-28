using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // Required for handling files
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class ProductEntry : Form
    {
        // This holds the image data in a format that can be saved to the database
        private byte[] productImageData;
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public ProductEntry()
        {
            InitializeComponent();
        }

        private void ProductEntry_Load(object sender, EventArgs e)
        {
            // Populate the dropdown boxes with predefined values
            cmbProductType.Items.AddRange(new object[] { "Laptop","Desktop", "Smart Watch", "Phone", "Tablet", "Camera", "TV","Monitor", "Accessories", "Headphones", "Webcam" });
            cmbStatus.Items.AddRange(new object[] { "In Stock", "Out of Stock", "Pre-Order" });
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            // Open a dialog to let the user select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select a Product Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Display the selected image in the PictureBox
                    picProductImage.Image = new Bitmap(openFileDialog.FileName);

                    // Convert the image into a byte array to be stored in the database
                    productImageData = File.ReadAllBytes(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            // --- 1. VALIDATION ---
            if (string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                cmbProductType.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                cmbStatus.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCurrentPrice.Text) ||
                string.IsNullOrWhiteSpace(txtRegularPrice.Text) ||
                productImageData == null) // Check if an image was selected
            {
                MessageBox.Show("Please fill out all required fields and select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtCurrentPrice.Text, out decimal currentPrice) || !decimal.TryParse(txtRegularPrice.Text, out decimal regularPrice))
            {
                MessageBox.Show("Please enter valid decimal numbers for prices.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 2. DATABASE INSERTION ---
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    // The SQL INSERT statement matching your table columns
                    string query = "INSERT INTO Product_Details (Product_code, Image, Product_type, Brand_name, Model, Status, Current_Price, Regular_Price, Available_Product, Key_Features) " +
                                   "VALUES (@ProductCode, @Image, @ProductType, @BrandName, @Model, @Status, @CurrentPrice, @RegularPrice, @AvailableProduct, @KeyFeatures)";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        // Add parameters to prevent SQL Injection
                        sqlCmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);
                        sqlCmd.Parameters.AddWithValue("@ProductType", cmbProductType.SelectedItem.ToString());
                        sqlCmd.Parameters.AddWithValue("@BrandName", txtBrand.Text);
                        sqlCmd.Parameters.AddWithValue("@Model", txtModel.Text);
                        sqlCmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        sqlCmd.Parameters.AddWithValue("@CurrentPrice", currentPrice);
                        sqlCmd.Parameters.AddWithValue("@RegularPrice", regularPrice);
                        sqlCmd.Parameters.AddWithValue("@AvailableProduct", (int)numAvailable.Value);
                        sqlCmd.Parameters.AddWithValue("@KeyFeatures", txtFeatures.Text);

                        // Special handling for the image data (VARBINARY)
                        SqlParameter imageParameter = new SqlParameter("@Image", SqlDbType.VarBinary, -1)
                        {
                            Value = productImageData
                        };
                        sqlCmd.Parameters.Add(imageParameter);

                        sqlCmd.ExecuteNonQuery(); // Execute the command

                        MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm(); // Clear the form for the next entry
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            // Reset all controls to their default state
            txtProductCode.Clear();
            cmbProductType.SelectedIndex = -1;
            txtBrand.Clear();
            txtModel.Clear();
            cmbStatus.SelectedIndex = -1;
            txtCurrentPrice.Clear();
            txtRegularPrice.Clear();
            numAvailable.Value = 0;
            txtFeatures.Clear();
            picProductImage.Image = null;
            productImageData = null;
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}