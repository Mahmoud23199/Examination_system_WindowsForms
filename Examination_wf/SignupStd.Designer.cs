namespace Examination_wf
{
    partial class SignupStd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupStd));
            pictureBox1 = new PictureBox();
            Fname = new TextBox();
            Lname = new TextBox();
            Username = new TextBox();
            Password = new TextBox();
            Address = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Register = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(562, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 154);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Fname
            // 
            Fname.Location = new Point(132, 225);
            Fname.Name = "Fname";
            Fname.Size = new Size(223, 27);
            Fname.TabIndex = 9;
            // 
            // Lname
            // 
            Lname.Location = new Point(473, 228);
            Lname.Name = "Lname";
            Lname.Size = new Size(223, 27);
            Lname.TabIndex = 10;
            // 
            // Username
            // 
            Username.Location = new Point(132, 276);
            Username.Name = "Username";
            Username.Size = new Size(223, 27);
            Username.TabIndex = 11;
            // 
            // Password
            // 
            Password.Location = new Point(473, 279);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(223, 27);
            Password.TabIndex = 12;
            // 
            // Address
            // 
            Address.Location = new Point(132, 328);
            Address.Name = "Address";
            Address.Size = new Size(223, 27);
            Address.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 228);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 14;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(388, 228);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 15;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 279);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 16;
            label3.Text = "User Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(388, 283);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 328);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 18;
            label5.Text = "Address";
            // 
            // btn_Register
            // 
            btn_Register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Register.Location = new Point(357, 402);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(147, 41);
            btn_Register.TabIndex = 19;
            btn_Register.Text = "register ";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 21);
            label6.Name = "label6";
            label6.Size = new Size(305, 54);
            label6.TabIndex = 20;
            label6.Text = "Create account";
            // 
            // SignupStd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(908, 536);
            Controls.Add(label6);
            Controls.Add(btn_Register);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Address);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Lname);
            Controls.Add(Fname);
            Controls.Add(pictureBox1);
            Name = "SignupStd";
            Text = "SignupStd";
            Load += SignupStd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Fname;
        private TextBox Lname;
        private TextBox Username;
        private TextBox Password;
        private TextBox Address;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Register;
        private Label label6;
    }
}