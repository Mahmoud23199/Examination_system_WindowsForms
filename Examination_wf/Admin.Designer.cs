namespace Examination_wf
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            button1 = new Button();
            userAdmin = new TextBox();
            passwordAdmin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(408, 369);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // userAdmin
            // 
            userAdmin.Location = new Point(372, 255);
            userAdmin.Name = "userAdmin";
            userAdmin.Size = new Size(218, 27);
            userAdmin.TabIndex = 1;
            // 
            // passwordAdmin
            // 
            passwordAdmin.Location = new Point(372, 308);
            passwordAdmin.Name = "passwordAdmin";
            passwordAdmin.PasswordChar = '*';
            passwordAdmin.Size = new Size(218, 27);
            passwordAdmin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 255);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 3;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(255, 308);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(362, 156);
            label3.Name = "label3";
            label3.Size = new Size(243, 43);
            label3.TabIndex = 5;
            label3.Text = "Login As Admin";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 147);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(856, 526);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordAdmin);
            Controls.Add(userAdmin);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox userAdmin;
        private TextBox passwordAdmin;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}