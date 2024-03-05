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
    public partial class StartExam : Form
    {
        private int user;
        private int courId;
        public StartExam(int userId, int courseId)
        {
            user = userId;
            courId = courseId;
            InitializeComponent();
        }
        ExamDbContext examDb = new ExamDbContext();

        private void StartExam_Load(object sender, EventArgs e)
        {

            // var listQuestion = examDb.Questions.Where(i => i.CourseId == courId && i.Question_type=="TrueFalse").Select(i => new { Q = i.Descrption }).ToList();

            //dataGridView1.DataSource = listQuestion;
            var random = new Random();
            var listQuRandom = examDb.Questions
                .Where(i => i.CourseId == courId && i.Question_type == "TrueFalse")
                .Select(i => new { Q = i.Descrption })
                .AsEnumerable()
                .OrderBy(_ => random.Next())
                .Take(8)
                .ToList();
            //-----------------------------------

            foreach (var question in listQuRandom)
            {
                listBox1.Items.Add(question + "\n");
            }


            comboBox1.Items.Add("True");
            comboBox1.Items.Add("False");
            comboBox2.Items.Add("True");
            comboBox2.Items.Add("False");
            comboBox3.Items.Add("True");
            comboBox3.Items.Add("False");
            comboBox4.Items.Add("True");
            comboBox4.Items.Add("False");
            comboBox5.Items.Add("True");
            comboBox5.Items.Add("False");
            comboBox6.Items.Add("True");
            comboBox6.Items.Add("False");
            comboBox7.Items.Add("True");
            comboBox7.Items.Add("False");
            comboBox8.Items.Add("True");
            comboBox8.Items.Add("False");


            btnNext.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            btnNext.ForeColor = Color.White; // Set text color
            btnNext.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            btnNext.FlatStyle = FlatStyle.Flat; // Set flat style
            btnNext.FlatAppearance.BorderSize = 0;


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var modelAnswers = examDb.Questions
                            .Where(i => i.CourseId == courId && i.Question_type=="TrueFalse")
                            .Select(i => i.Model_answer)
                            .ToList();

            List<string> stdAnswers = new List<string>();

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null ||
                comboBox4.SelectedItem == null || comboBox5.SelectedItem == null || comboBox6.SelectedItem == null ||
                comboBox7.SelectedItem == null || comboBox8.SelectedItem == null)
            {
                MessageBox.Show("You must answer all questions.", "Missing Answers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                stdAnswers.Add(comboBox1.SelectedItem.ToString());
                stdAnswers.Add(comboBox2.SelectedItem.ToString());
                stdAnswers.Add(comboBox3.SelectedItem.ToString());
                stdAnswers.Add(comboBox4.SelectedItem.ToString());
                stdAnswers.Add(comboBox5.SelectedItem.ToString());
                stdAnswers.Add(comboBox6.SelectedItem.ToString());
                stdAnswers.Add(comboBox7.SelectedItem.ToString());
                stdAnswers.Add(comboBox8.SelectedItem.ToString());

                var markTrue = 0;
                for (int i = 0; i < modelAnswers.Count; i++)
                {
                    if (stdAnswers[i] == modelAnswers[i]) 
                    {
                        markTrue += 5;
                    }

                }
                
                SecondPageQ secondPageQ = new SecondPageQ(markTrue,courId,user);
                secondPageQ.Show();
                this.Hide();

            }

            
        }
    }
}
