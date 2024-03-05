namespace Examination_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExamDbContext examDbContext = new ExamDbContext();
            var user = userNameStd.Text;
            var password = passwordStd.Text;

            var userMatch = examDbContext.Students.FirstOrDefault(i => i.userName == user && i.Password == password);
            if (userMatch != null)
            {
                var stdId=examDbContext.Students.Where(i=>i.userName == user).Select(i=>i.Student_id).FirstOrDefault();
                ExamRoom examRoom = new ExamRoom(stdId);
                examRoom.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                userNameStd.Clear();
                passwordStd.Clear();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();




        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SignupStd signupStd = new SignupStd();
            signupStd.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            button1.ForeColor = Color.White; // Set text color
            button1.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            button1.FlatStyle = FlatStyle.Flat; // Set flat style
            button1.FlatAppearance.BorderSize = 0;

            btnAdmin.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            btnAdmin.ForeColor = Color.White; // Set text color
            btnAdmin.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            btnAdmin.FlatStyle = FlatStyle.Flat; // Set flat style
            btnAdmin.FlatAppearance.BorderSize = 0;

            btnStudentLogin.BackColor = Color.FromArgb(52, 152, 219); // Set background color
            btnStudentLogin.ForeColor = Color.White; // Set text color
            btnStudentLogin.Font = new Font("Arial", 12, FontStyle.Bold); // Set font and size
            btnStudentLogin.FlatStyle = FlatStyle.Flat; // Set flat style
            btnStudentLogin.FlatAppearance.BorderSize = 0;
        }
    }
    
}
