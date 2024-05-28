using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");

        // Initializing login page
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
        }

        // Event Handler for Login button, verify the fields and provide access if valid user
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameTxt.Text;
            string password = this.passwordTxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("No empty space allowed");
                return;
            }

            string passwordValidationResult = ValidatePassword(password);
            if (!string.IsNullOrEmpty(passwordValidationResult))
            {
                MessageBox.Show(passwordValidationResult);
                return;
            }

            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem"))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (password == reader.GetString("password"))
                        {
                            Home home = new Home();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You have entered an invalid password. Please try again!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found. Please check your username.");
                    }
                }
            }
        }

        private string ValidatePassword(string password)
        {
            if (password.Length < 8)
                return "Password must be at least 8 characters long.";
            if (password.Length > 16)
                return "Password must be no longer than 16 characters.";
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return "Password must contain at least one uppercase letter.";
            if (!Regex.IsMatch(password, @"[a-z]"))
                return "Password must contain at least one lowercase letter.";
            if (!Regex.IsMatch(password, @"[0-9]"))
                return "Password must contain at least one numeric digit.";
            if (!Regex.IsMatch(password, @"[\W_]"))
                return "Password must contain at least one special character.";

            return string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
