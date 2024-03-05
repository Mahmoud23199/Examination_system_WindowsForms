namespace Examination_wf
{
    partial class AddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestion));
            textQuestion = new TextBox();
            textModelAnswer = new TextBox();
            textMark = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboCourse = new ComboBox();
            comboType = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            comboUser = new ComboBox();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textQuestion
            // 
            textQuestion.Location = new Point(239, 222);
            textQuestion.Name = "textQuestion";
            textQuestion.Size = new Size(210, 27);
            textQuestion.TabIndex = 0;
            // 
            // textModelAnswer
            // 
            textModelAnswer.Location = new Point(603, 307);
            textModelAnswer.Name = "textModelAnswer";
            textModelAnswer.Size = new Size(210, 27);
            textModelAnswer.TabIndex = 3;
            // 
            // textMark
            // 
            textMark.Location = new Point(603, 222);
            textMark.Name = "textMark";
            textMark.Size = new Size(210, 27);
            textMark.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 218);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 6;
            label1.Text = "Question";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(487, 306);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 8;
            label3.Text = "Answer";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(487, 222);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 9;
            label4.Text = "Mark";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(130, 302);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 10;
            label5.Text = "Type";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(130, 390);
            label6.Name = "label6";
            label6.Size = new Size(87, 31);
            label6.TabIndex = 11;
            label6.Text = "Course";
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(239, 396);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(210, 28);
            comboCourse.TabIndex = 12;
            comboCourse.SelectedIndexChanged += comboCourse_SelectedIndexChanged;
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(239, 306);
            comboType.Name = "comboType";
            comboType.Size = new Size(210, 28);
            comboType.TabIndex = 13;
            comboType.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(471, 497);
            button1.Name = "button1";
            button1.Size = new Size(142, 54);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(487, 393);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 16;
            label2.Text = "UserName";
            // 
            // comboUser
            // 
            comboUser.FormattingEnabled = true;
            comboUser.Location = new Point(603, 397);
            comboUser.Name = "comboUser";
            comboUser.Size = new Size(210, 28);
            comboUser.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 156);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(931, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 47);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AddQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1080, 629);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(comboUser);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboType);
            Controls.Add(comboCourse);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textMark);
            Controls.Add(textModelAnswer);
            Controls.Add(textQuestion);
            ForeColor = Color.Black;
            Name = "AddQuestion";
            Text = "AddQuestion";
            Load += AddQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textQuestion;
        private TextBox textModelAnswer;
        private TextBox textMark;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboCourse;
        private ComboBox comboType;
        private Button button1;
        private Label label2;
        private ComboBox comboUser;
        private PictureBox pictureBox1;
        private Button btnLogout;
    }
}