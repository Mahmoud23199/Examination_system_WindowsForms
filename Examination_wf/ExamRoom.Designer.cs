namespace Examination_wf
{
    partial class ExamRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamRoom));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            btnStart = new Button();
            btnLog = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(340, 80);
            label1.Name = "label1";
            label1.Size = new Size(534, 52);
            label1.TabIndex = 9;
            label1.Text = "Welcome To your Exam";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 257);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 14;
            label6.Text = "Welcome";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(12, 196);
            label7.Name = "label7";
            label7.Size = new Size(101, 28);
            label7.TabIndex = 15;
            label7.Text = "Welcome";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(299, 151);
            dataGridView1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 313);
            label2.Name = "label2";
            label2.Size = new Size(299, 39);
            label2.TabIndex = 17;
            label2.Text = "Last Exam Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(383, 281);
            label3.Name = "label3";
            label3.Size = new Size(346, 43);
            label3.TabIndex = 18;
            label3.Text = "Choose The Next Exam";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(750, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 28);
            comboBox1.TabIndex = 19;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(786, 393);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(123, 40);
            btnStart.TabIndex = 21;
            btnStart.Text = "Start Exam";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(479, 481);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(94, 29);
            btnLog.TabIndex = 22;
            btnLog.Text = "Logout";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // ExamRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(972, 533);
            Controls.Add(btnLog);
            Controls.Add(btnStart);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ExamRoom";
            Text = "ExamRoom";
            Load += ExamRoom_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnStart;
        private Button btnLog;
    }
}