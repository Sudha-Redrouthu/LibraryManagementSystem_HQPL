using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        // Initializing home page
        public Home()
        {
            InitializeComponent();
        }

        // Event Handler for add books button
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            addBooks addb = new addBooks();
            addb.Show();
            this.Hide();
        }

        // Event Handler for view books button
        private void viewBookBtn_Click(object sender, EventArgs e)
        {
            viewBooks viewBooks = new viewBooks();
            viewBooks.Show();
            this.Hide();
        }

        // Event Handler for issue books button
        // private void issueBookBtn_Click(object sender, EventArgs e)
        // {
        //     issueBooks issueBooks = new issueBooks();
        //     issueBooks.Show();
        //     this.Hide();
        // }

        // Event Handler for add student button
        // private void addStudentBtn_Click(object sender, EventArgs e)
        // {
        //     addStudents addStudents = new addStudents();
        //     addStudents.Show();
        //     this.Hide();
        // }

        // Event Handler for view student info button
        // private void viewStudentInfoBtn_Click(object sender, EventArgs e)
        // {
        //     viewStudentInfo viewStudentInfo = new viewStudentInfo();
        //     viewStudentInfo.Show();
        //     this.Hide();
        // }

        // Event Handler for exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        // Event Handler for logout button
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            Login login = new Login();
            login.Show();
            this.Close(); // Close the current form instead of hiding it
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add appropriate event handler code here
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add appropriate event handler code here
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Add appropriate event handler code here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add appropriate event handler code here
        }
    }
}
