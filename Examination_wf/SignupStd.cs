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
    public partial class SignupStd : Form
    {
        public SignupStd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            ExamDbContext examDbContext = new ExamDbContext();
            var fname = Fname.Text;
            var lname = Lname.Text;
            var userName = Username.Text;
            var password = Password.Text;
            var address = Address.Text;

            Form1 form1 = new Form1();
            var uniqueuser = examDbContext.Students.FirstOrDefault(i => i.userName == userName);

            if (userName == "" || password == "" || fname == "" || lname == "")
            {
                MessageBox.Show("username or password or name is Required. Please try again.", "Sign Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (uniqueuser != null)
            {
                MessageBox.Show("username not correct. Please try again.", "Sign Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username.Clear();
            }
            else
            {
                var std = new Student { Fname = fname, Lname = lname, userName = userName, Address = address, Password = password };

                examDbContext.Students.Add(std);
                examDbContext.SaveChanges();

                MessageBox.Show("Registration successful! You can now log in.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form1.Show();
                this.Hide();
                Fname.Clear();
                Lname.Clear();
                Username.Clear();
                Password.Clear();
                Address.Clear();
            }






        }

        private void SignupStd_Load(object sender, EventArgs e)
        {
            btn_Register.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            btn_Register.ForeColor = Color.White; // Set text color
            btn_Register.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            btn_Register.FlatStyle = FlatStyle.Flat; // Set flat style
            btn_Register.FlatAppearance.BorderSize = 0;
        }
    }
}
