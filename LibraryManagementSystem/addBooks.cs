using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class addBooks : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");

        // Initializing add books window
        public addBooks()
        {
            InitializeComponent();
        }

        // Event Handler for save button 
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (ValidateInput())
            {
                if (IsDuplicateBook())
                {
                    MessageBox.Show("Duplicate book information found. Please enter unique book details.");
                    return;
                }

                try
                {
                    con.Open();
                    string query = "INSERT INTO book(book_name, ISBN, author, publisher, category, price, quantity) VALUES (@bookName, @isbn, @auth, @publisher, @category, @price, @quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@bookName", bookName.Text);
                    cmd.Parameters.AddWithValue("@isbn", isbn.Text);
                    cmd.Parameters.AddWithValue("@auth", author.Text);
                    cmd.Parameters.AddWithValue("@publisher", publisher.Text);
                    cmd.Parameters.AddWithValue("@category", category.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(price.Text));
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt64(qty.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("You have successfully added the book details");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Method to validate input data before adding to the database of books
        private bool ValidateInput()
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(bookName.Text) ||
                string.IsNullOrWhiteSpace(isbn.Text) ||
                string.IsNullOrWhiteSpace(author.Text) ||
                string.IsNullOrWhiteSpace(publisher.Text) ||
                string.IsNullOrWhiteSpace(category.Text) ||
                string.IsNullOrWhiteSpace(price.Text) ||
                string.IsNullOrWhiteSpace(qty.Text))
            {
                // Display an error message if any required field is empty
                MessageBox.Show("Please fill in all required fields.");
                return false; // Validation failed
            }

            // Validate ISBN is numeric
            if (!Regex.IsMatch(isbn.Text, @"^\d+$"))
            {
                MessageBox.Show("ISBN should be numeric.");
                return false;
            }

            // Validate book name contains only alphabets
            if (!Regex.IsMatch(bookName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Book name should contain only alphabets.");
                return false;
            }

            // Validate price is a valid numeric value
            if (!double.TryParse(price.Text, out _))
            {
                MessageBox.Show("Please enter a valid price.");
                return false;
            }

            // Validate quantity is a valid numeric value
            if (!int.TryParse(qty.Text, out _))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return false;
            }

            // Validate author name contains first name and last name
            var authorParts = author.Text.Split(' ');
            if (authorParts.Length < 2)
            {
                MessageBox.Show("Author name should contain first name and last name.");
                return false;
            }

            // All validation checks passed
            return true;
        }

        private bool IsDuplicateBook()
        {
            string query = "SELECT COUNT(*) FROM book WHERE book_name = @bookName AND ISBN = @isbn AND author = @auth";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@bookName", bookName.Text);
            cmd.Parameters.AddWithValue("@isbn", isbn.Text);
            cmd.Parameters.AddWithValue("@auth", author.Text);

            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            return count > 0;
        }

        private void ClearFields()
        {
            bookName.Text = "";
            isbn.Text = "";
            author.Text = "";
            publisher.Text = "";
            category.Text = "";
            price.Text = "";
            qty.Text = "";
        }

        // Event Handler for view books button
        private void viewBookBtn_Click(object sender, EventArgs e)
        {
            viewBooks vb = new viewBooks();
            vb.Show();
            this.Hide();
        }

        // Event Handler for exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        // Event Handler for clear button
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Event Handler for cancel button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void addBooks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Event Handler for logout button
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            Login login = new Login();
            login.Show();
            this.Close(); // Close the current form instead of hiding it
        }
    }
}
