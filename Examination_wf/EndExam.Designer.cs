namespace Examination_wf
{
    partial class EndExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndExam));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelTotal = new Label();
            label2 = new Label();
            label4 = new Label();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 154);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 269);
            label1.Name = "label1";
            label1.Size = new Size(343, 37);
            label1.TabIndex = 9;
            label1.Text = "Your Total Mark is :";
            label1.Click += label1_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(385, 269);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(59, 37);
            labelTotal.TabIndex = 11;
            labelTotal.Text = "00 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(468, 269);
            label2.Name = "label2";
            label2.Size = new Size(52, 37);
            label2.TabIndex = 12;
            label2.Text = "80";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(432, 269);
            label4.Name = "label4";
            label4.Size = new Size(30, 37);
            label4.TabIndex = 13;
            label4.Text = "/";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(348, 374);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(123, 29);
            btnHome.TabIndex = 14;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // EndExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHome);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelTotal);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EndExam";
            Text = "EndExam";
            Load += EndExam_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label labelTotal;
        private Label label2;
        private Label label4;
        private Button btnHome;
    }
}