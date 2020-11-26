using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class TeacherActivity : Form
    {
        int teacherid;
        public string tname;
        public TeacherActivity()
        {
            InitializeComponent();
            teacherid = teacherLogin.TeacherID;
            teachername.Text = teacherLogin.teacherName;
            tname = teachername.Text;
        }

        private void students_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            this.Hide();
            teacher.Show();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            ManageQuiz manage = new ManageQuiz();
            this.Hide();
            manage.Show();
        }

       


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherActivity_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AccountType account = new AccountType();
            this.Hide();
            account.Show();
        }
    }
}
