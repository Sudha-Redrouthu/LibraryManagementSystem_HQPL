using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class viewBooks : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");

        // Initializing the view books window
        public viewBooks()
        {
            InitializeComponent();
        }

        // Event Handler for search button
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DBAccess db1 = new DBAccess();
                string query2 = ("SELECT COUNT(*) FROM BOOK where book_name = '" + textBox1.Text + "' OR ISBN = '" + textBox1.Text + "'");
                using (MySqlCommand command = new MySqlCommand(query2, con))
                {
                    con.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)

                    {
                        MySqlDataAdapter view_t = new MySqlDataAdapter("select book_id,book_name,ISBN,author,publisher,category,price,quantity from book where book_name = '" + textBox1.Text + "' OR ISBN = '" + textBox1.Text + "'", con);
                        DataTable DT3 = new DataTable();
                        view_t.Fill(DT3);
                        dataGridView1.DataSource = DT3;
                        con.Close();
                    }

                    else
                    {
                        MessageBox.Show("Book Data does not exist");
                        con.Close();
                    }
                }
            }
        }

        // Event Handler for add books button
        private void addBooksBtn_Click(object sender, EventArgs e)
        {
            addBooks ab = new addBooks();
            ab.Show();
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
            textBox1.Text = "";
            dataGridView1.DataSource = null;
        }

        // Event Handler for cancel button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
