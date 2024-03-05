namespace Examination_wf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            userNameStd = new TextBox();
            passwordStd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnStudentLogin = new Button();
            btnAdmin = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userNameStd
            // 
            userNameStd.Location = new Point(414, 298);
            userNameStd.Name = "userNameStd";
            userNameStd.Size = new Size(260, 27);
            userNameStd.TabIndex = 0;
            // 
            // passwordStd
            // 
            passwordStd.Location = new Point(414, 356);
            passwordStd.Name = "passwordStd";
            passwordStd.PasswordChar = '*';
            passwordStd.Size = new Size(260, 27);
            passwordStd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 301);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(305, 359);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnStudentLogin
            // 
            btnStudentLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentLogin.Location = new Point(425, 411);
            btnStudentLogin.Name = "btnStudentLogin";
            btnStudentLogin.Size = new Size(102, 35);
            btnStudentLogin.TabIndex = 4;
            btnStudentLogin.Text = "Login";
            btnStudentLogin.UseVisualStyleBackColor = true;
            btnStudentLogin.Click += button1_Click_1;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Location = new Point(747, 12);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(172, 42);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Login as Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(415, 163);
            label3.Name = "label3";
            label3.Size = new Size(259, 56);
            label3.TabIndex = 6;
            label3.Text = "Examination";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 154);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(566, 411);
            button1.Name = "button1";
            button1.Size = new Size(95, 35);
            button1.TabIndex = 8;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(969, 563);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnAdmin);
            Controls.Add(btnStudentLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordStd);
            Controls.Add(userNameStd);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameStd;
        private TextBox passwordStd;
        private Label label1;
        private Label label2;
        private Button btnStudentLogin;
        private Button btnAdmin;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
