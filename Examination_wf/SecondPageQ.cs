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
    public partial class SecondPageQ : Form
    {
        int totalMark;
        private int courId;
        private int userId;

        ExamDbContext examDb =new ExamDbContext();
        public SecondPageQ(int mark,int courseid, int userid)
        {
            totalMark = mark;
            courId = courseid;
            userId = userid;
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var modelAnswers = examDb.Questions
                            .Where(i => i.CourseId == courId && i.Question_type == "Choose")
                            .Select(i => i.Model_answer)
                            .Take(8)
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

                for (int i = 0; i < modelAnswers.Count; i++)
                {
                    if (stdAnswers[i] == modelAnswers[i])
                    {
                        totalMark += 5;
                    }

                }
                //----------save mark in db--------------------------

                var Ename = examDb.Courses.Where(i => i.Crs_id == courId).Select(i => i.Name).FirstOrDefault();

                var examtory = new ExamHistory
                {
                    ExamName = Ename,
                    CourseId = courId,
                    StudentId = userId,
                    TotalMark = totalMark
                };


                examDb.ExamHistorys.Add(examtory);
                examDb.SaveChanges();

                //-----------------------------------------------------
                EndExam endExam = new EndExam(totalMark, userId);
                endExam.Show();
                this.Hide();

            }

          
        }

        private void SecondPageQ_Load(object sender, EventArgs e)
        {

            var random = new Random();
            var listQuRandom = examDb.Questions
                .Where(i => i.CourseId == courId && i.Question_type == "Choose")
                .Select(i => new { Q = i.Descrption })
                .AsEnumerable()
                .Take(8)
                .OrderBy(_ => random.Next())
                .ToList();
            //-updated 
            //var listQuestion = examDb.Questions.Where(i => i.CourseId == courId && i.Question_type== "Choose").Select(i => new { Q = i.Descrption }).ToList();


            foreach (var question in listQuRandom)
            {
                listBox1.Items.Add(question + "\n");
            }























            comboBox1.Items.Add("16");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("32");
            comboBox1.Items.Add("8");


            comboBox2.Items.Add("32");
            comboBox2.Items.Add("16");
            comboBox2.Items.Add("8");
            comboBox2.Items.Add("4");

            comboBox3.Items.Add("314");
            comboBox3.Items.Add("22");
            comboBox3.Items.Add("3.14");
            comboBox3.Items.Add("14");

            comboBox4.Items.Add("boolean");
            comboBox4.Items.Add("string");
            comboBox4.Items.Add("int");
            comboBox4.Items.Add("flag");

            comboBox5.Items.Add("12");
            comboBox5.Items.Add("10");
            comboBox5.Items.Add("18");
            comboBox5.Items.Add("14");

            comboBox6.Items.Add("10");
            comboBox6.Items.Add("8");
            comboBox6.Items.Add("18");
            comboBox6.Items.Add("15");

            comboBox7.Items.Add("8");
            comboBox7.Items.Add("5");
            comboBox7.Items.Add("3");
            comboBox7.Items.Add("11");

            comboBox8.Items.Add("6");
            comboBox8.Items.Add("4");
            comboBox8.Items.Add("3");
            comboBox8.Items.Add("5");


            btnEnd.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            btnEnd.ForeColor = Color.White; // Set text color
            btnEnd.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            btnEnd.FlatStyle = FlatStyle.Flat; // Set flat style
            btnEnd.FlatAppearance.BorderSize = 0;

        }
    }
}
