namespace LibraryManagementSystem
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            addStudentBtn = new Button();
            viewBookBtn = new Button();
            exitBtn = new Button();
            addBookBtn = new Button();
            issueBookBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 42);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(743, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(611, 9);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Welcome , Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 25);
            label1.TabIndex = 0;
            label1.Text = "Conestoga Library Management System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(addStudentBtn);
            panel2.Controls.Add(viewBookBtn);
            panel2.Controls.Add(exitBtn);
            panel2.Controls.Add(addBookBtn);
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 417);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 113);
            button4.Name = "button4";
            button4.Size = new Size(170, 43);
            button4.TabIndex = 15;
            button4.Text = "Book Details";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 211);
            button3.Name = "button3";
            button3.Size = new Size(170, 43);
            button3.TabIndex = 14;
            button3.Text = "View Student Info";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 309);
            button2.Name = "button2";
            button2.Size = new Size(170, 43);
            button2.TabIndex = 13;
            button2.Text = "Return Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 260);
            button1.Name = "button1";
            button1.Size = new Size(170, 43);
            button1.TabIndex = 12;
            button1.Text = "Issue Books";
            button1.UseVisualStyleBackColor = false;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = SystemColors.GradientInactiveCaption;
            addStudentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentBtn.Location = new Point(12, 162);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(170, 43);
            addStudentBtn.TabIndex = 10;
            addStudentBtn.Text = "Add Student";
            addStudentBtn.UseVisualStyleBackColor = false;
            // 
            // viewBookBtn
            // 
            viewBookBtn.BackColor = SystemColors.GradientInactiveCaption;
            viewBookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewBookBtn.Location = new Point(12, 64);
            viewBookBtn.Name = "viewBookBtn";
            viewBookBtn.Size = new Size(170, 43);
            viewBookBtn.TabIndex = 8;
            viewBookBtn.Text = "View Book";
            viewBookBtn.UseVisualStyleBackColor = false;
            viewBookBtn.Click += viewBookBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.AliceBlue;
            exitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(12, 358);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(170, 43);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // addBookBtn
            // 
            addBookBtn.BackColor = SystemColors.GradientInactiveCaption;
            addBookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBookBtn.Location = new Point(12, 15);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(170, 43);
            addBookBtn.TabIndex = 2;
            addBookBtn.Text = "Add Book";
            addBookBtn.UseVisualStyleBackColor = false;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // issueBookBtn
            // 
            issueBookBtn.BackColor = SystemColors.GradientInactiveCaption;
            issueBookBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issueBookBtn.Location = new Point(12, 162);
            issueBookBtn.Name = "issueBookBtn";
            issueBookBtn.Size = new Size(170, 43);
            issueBookBtn.TabIndex = 9;
            issueBookBtn.Text = "Issue Book";
            issueBookBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(254, 395);
            label3.Name = "label3";
            label3.Size = new Size(278, 20);
            label3.TabIndex = 2;
            label3.Text = "Enlightening Lives, One Book At A Time !";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(611, 75);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 3;
            label4.Text = "Hi , Welcome Back ,";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button viewBookBtn;
        private Button exitBtn;
        private Button addBookBtn;
        private Button addStudentBtn;
        private Button issueBookBtn;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}