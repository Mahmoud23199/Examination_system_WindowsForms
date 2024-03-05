using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_wf
{
    public partial class ExamRoom : Form
    {
        private int userId;
        public ExamRoom(int userid)
        {
            InitializeComponent();
            this.userId = userid;

        }

        ExamDbContext examDb = new ExamDbContext();

        private void ExamRoom_Load(object sender, EventArgs e)
        {
            var std_Data = examDb.Students.FirstOrDefault(i => i.Student_id == userId);

            if (std_Data != null)
            {
                label7.Text = "Name: " + std_Data.Fname + " " + std_Data.Lname;
                label6.Text = "Address: " + std_Data.Address;
            }

            var infolist = examDb.ExamHistorys.Where(e => e.StudentId == userId).ToList();


            var examHistoryList = examDb.ExamHistorys
                                 .Where(e => e.StudentId == userId)
                                 .Select(item => new { ExamName = item.ExamName, TotalMark = item.TotalMark })
                                 .ToList();

            dataGridView1.DataSource = examHistoryList;


            var courseName = examDb.Courses.Select(i => i.Name).ToList();

            foreach (var item in courseName)
            {
                comboBox1.Items.Add(item);
                comboBox1.SelectedIndex = 0;

            }





            btnStart.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            btnStart.ForeColor = Color.White; // Set text color
            btnStart.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            btnStart.FlatStyle = FlatStyle.Flat; // Set flat style
            btnStart.FlatAppearance.BorderSize = 0;



        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var courseName = comboBox1.SelectedItem.ToString();
            var courseId = examDb.Courses.Where(i => i.Name == courseName).Select(i => i.Crs_id).FirstOrDefault();

            StartExam startExam = new StartExam(userId, courseId);
            startExam.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
