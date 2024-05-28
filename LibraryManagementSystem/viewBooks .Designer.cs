namespace LibraryManagementSystem
{
    partial class viewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBooks));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            addBooksBtn = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            viewStudentInfoBtn = new System.Windows.Forms.Button();
            addStudentBtn = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            panel4 = new System.Windows.Forms.Panel();
            updateBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            cancelBtn = new System.Windows.Forms.Button();
            clearBtn = new System.Windows.Forms.Button();
            searchBtn = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(801, 42);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(743, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(33, 33);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(611, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Welcome , Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(328, 25);
            label1.TabIndex = 0;
            label1.Text = "Conestoga Library Management System";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(addBooksBtn);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(viewStudentInfoBtn);
            panel2.Controls.Add(addStudentBtn);
            panel2.Location = new System.Drawing.Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(195, 417);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.Location = new System.Drawing.Point(12, 358);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(170, 43);
            button4.TabIndex = 17;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(12, 212);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(170, 43);
            button3.TabIndex = 16;
            button3.Text = "View Student Info";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(12, 112);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(170, 43);
            button2.TabIndex = 15;
            button2.Text = "Book Details";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(12, 163);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(170, 43);
            button1.TabIndex = 14;
            button1.Text = "Add Students";
            button1.UseVisualStyleBackColor = false;
            // 
            // addBooksBtn
            // 
            addBooksBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            addBooksBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addBooksBtn.Location = new System.Drawing.Point(12, 16);
            addBooksBtn.Name = "addBooksBtn";
            addBooksBtn.Size = new System.Drawing.Size(170, 43);
            addBooksBtn.TabIndex = 13;
            addBooksBtn.Text = "Add Books";
            addBooksBtn.UseVisualStyleBackColor = false;
            addBooksBtn.Click += new System.EventHandler(this.addBooksBtn_Click);
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.SteelBlue;
            button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button5.Location = new System.Drawing.Point(12, 63);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(170, 43);
            button5.TabIndex = 12;
            button5.Text = "View Books";
            button5.UseVisualStyleBackColor = false;
            // 
            // viewStudentInfoBtn
            // 
            viewStudentInfoBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            viewStudentInfoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewStudentInfoBtn.Location = new System.Drawing.Point(12, 309);
            viewStudentInfoBtn.Name = "viewStudentInfoBtn";
            viewStudentInfoBtn.Size = new System.Drawing.Size(170, 43);
            viewStudentInfoBtn.TabIndex = 11;
            viewStudentInfoBtn.Text = "Return Book";
            viewStudentInfoBtn.UseVisualStyleBackColor = false;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            addStudentBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addStudentBtn.Location = new System.Drawing.Point(12, 260);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new System.Drawing.Size(170, 43);
            addStudentBtn.TabIndex = 10;
            addStudentBtn.Text = "Issue Book";
            addStudentBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Teal;
            panel3.Controls.Add(label3);
            panel3.Location = new System.Drawing.Point(217, 64);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(559, 32);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(15, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 20);
            label3.TabIndex = 0;
            label3.Text = " View Book Details";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(175, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(158, 27);
            textBox1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Controls.Add(updateBtn);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(cancelBtn);
            panel4.Controls.Add(clearBtn);
            panel4.Controls.Add(searchBtn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox1);
            panel4.Location = new System.Drawing.Point(217, 102);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(559, 321);
            panel4.TabIndex = 4;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = System.Drawing.Color.ForestGreen;
            updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            updateBtn.Location = new System.Drawing.Point(399, 266);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new System.Drawing.Size(143, 36);
            updateBtn.TabIndex = 21;
            updateBtn.Text = "Update Book Info";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(15, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(527, 188);
            dataGridView1.TabIndex = 20;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = System.Drawing.Color.Crimson;
            cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cancelBtn.Location = new System.Drawing.Point(162, 266);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(114, 36);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // clearBtn
            // 
            clearBtn.BackColor = System.Drawing.Color.Gray;
            clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            clearBtn.Location = new System.Drawing.Point(29, 266);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new System.Drawing.Size(114, 36);
            clearBtn.TabIndex = 18;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            searchBtn.BackColor = System.Drawing.Color.MidnightBlue;
            searchBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            searchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            searchBtn.Location = new System.Drawing.Point(360, 11);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new System.Drawing.Size(106, 32);
            searchBtn.TabIndex = 17;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 17);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(140, 20);
            label4.TabIndex = 8;
            label4.Text = "Book Name / ISBN :";
            // 
            // viewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(panel4);
            this.Controls.Add(panel3);
            this.Controls.Add(panel1);
            this.Controls.Add(panel2);
            this.Name = "viewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewBooks Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button viewStudentInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBooksBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
