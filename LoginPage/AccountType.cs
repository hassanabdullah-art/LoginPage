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
    public partial class AccountType : Form
    {
        public AccountType()
        {
            InitializeComponent();
        }

        private void teacherbtn_Click(object sender, EventArgs e)
        {
            teacherLogin teacher = new teacherLogin();
            this.Hide();
            teacher.Show();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            adminLogin admin = new adminLogin();
            this.Hide();
            admin.Show();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            studentLogin student = new studentLogin();
            this.Hide();
            student.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void AccountType_Load(object sender, EventArgs e)
        {
           int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        //logout function
        


       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            studentLogin student = new studentLogin();
            this.Hide();
            student.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            studentLogin student = new studentLogin();
            this.Hide();
            student.Show();
        }

       

        private void label1_Click_1(object sender, EventArgs e)
        {
            adminLogin admin = new adminLogin();
            this.Hide();
            admin.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            adminLogin admin = new adminLogin();
            this.Hide();
            admin.Show();

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            teacherLogin teacher = new teacherLogin();
            this.Hide();
            teacher.Show();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            teacherLogin teacher = new teacherLogin();
            this.Hide();
            teacher.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            studentLogin student = new studentLogin();
            this.Hide();
            student.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Student_view_Video student_View_Video = new Student_view_Video();
            this.Hide();
            student_View_Video.Show();
        }
    }
}
