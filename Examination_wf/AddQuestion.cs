using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Examination_wf
{
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            comboCourse.Items.Add("Java");
            comboCourse.Items.Add("C#");
            comboCourse.Items.Add("Html");
            comboCourse.Items.Add("OOP");
            comboCourse.SelectedIndex = 0;


            comboType.Items.Add("TrueFalse");
            comboType.Items.Add("Choose");
            comboType.SelectedIndex = 0;

            ExamDbContext examDb = new ExamDbContext();

            var instUser = examDb.Instructors.Select(i => i.userName).ToList();

            foreach (var inst in instUser)
            {
                comboUser.Items.Add(inst);

            }
            comboUser.SelectedIndex = 0;



            button1.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            button1.ForeColor = Color.White; // Set text color
            button1.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            button1.FlatStyle = FlatStyle.Flat; // Set flat style
            button1.FlatAppearance.BorderSize = 0;


            btnLogout.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            btnLogout.ForeColor = Color.White; // Set text color
            btnLogout.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            btnLogout.FlatStyle = FlatStyle.Flat; // Set flat style
            btnLogout.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamDbContext examDb = new ExamDbContext();

            var question = textQuestion.Text;
            var mark = textMark.Text;
            var modelAnswer = textModelAnswer.Text;
            var type = comboType.SelectedItem.ToString();
            var course = comboCourse.SelectedItem.ToString();
            var instUser = comboUser.SelectedItem.ToString();


            if (question == "" || modelAnswer == "" || type == "" || mark == "" || course == "")
            {
                MessageBox.Show("All fields is Required. Please try again.", "Sign Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var courseId = examDb.Courses.Where(i => i.Name == course).Select(s => s.Crs_id).FirstOrDefault();
                var insId = examDb.Instructors.Where(i => i.userName == instUser).Select(s => s.Instructor_id).FirstOrDefault();
                var quest = new Question { Question_type = type, Descrption = question, Mark = int.Parse(mark), Model_answer = modelAnswer, CourseId = courseId, InstructorId = insId };
               
                examDb.Questions.Add(quest);
                examDb.SaveChanges();
                MessageBox.Show("Question Added successful!.", "Question Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textQuestion.Clear();
                textMark.Clear();
                textModelAnswer.Clear();







            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.Show();
            this.Hide();
        }
    }
}
