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
    public partial class ManageQuiz : Form
    {
        public static string tname;
        public ManageQuiz()
        {
            InitializeComponent();
            teachername.Text = teacherLogin.teacherName;
            tname = teachername.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddTopic add = new AddTopic();
            this.Hide();
            add.Show();
        }

        private void set_Click(object sender, EventArgs e)
        {
            setexam setexam = new setexam();
            this.Hide();
            setexam.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            TeacherActivity teacher = new TeacherActivity();
            this.Hide();
            teacher.Show();
        }

        private void ManageQuiz_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
