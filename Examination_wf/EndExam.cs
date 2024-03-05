using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_wf
{
    public partial class EndExam : Form
    {
        int totalMark;
        private int userId;
        public EndExam(int mark,int userid)
        {
            totalMark = mark;
            userId = userid;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EndExam_Load(object sender, EventArgs e)
        {





            labelTotal.Text = totalMark.ToString();



            btnHome.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            btnHome.ForeColor = Color.White; // Set text color
            btnHome.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            btnHome.FlatStyle = FlatStyle.Flat; // Set flat style
            btnHome.FlatAppearance.BorderSize = 0;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ExamRoom examRoom = new ExamRoom(userId);
            examRoom.Show();
            this.Hide();


        }
    }
}
