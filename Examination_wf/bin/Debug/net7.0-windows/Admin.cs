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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            button1.ForeColor = Color.White; // Set text color
            button1.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            button1.FlatStyle = FlatStyle.Flat; // Set flat style
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamDbContext examDb = new ExamDbContext();
            var user = userAdmin.Text;
            var password=passwordAdmin.Text;

            var valid = examDb.Instructors.FirstOrDefault(i => i.userName == user && i.Password == password);

            if (valid != null) 
            {
                AddQuestion addQuestion = new AddQuestion();
                addQuestion.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                userAdmin.Clear();
                passwordAdmin.Clear();

            }
        }
    }
}
