namespace ProjectPP
{
    public static class CurrentUser
    {
        /// <summary>
        /// Stores the unique username, like 'sadik123'. Used for database queries.
        /// </summary>
        public static string UserName { get; set; }

        /// <summary>
        /// Stores the display name, like 'Sadik'. Used for welcome messages.
        /// </summary>
        public static string FullName { get; set; }
    }
}