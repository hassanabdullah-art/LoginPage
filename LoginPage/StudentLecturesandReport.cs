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
    public partial class StudentLecturesandReport : Form
    {
        string stName;
        string studentid;
        int stid;
        string stname;
        returnclass rc = new returnclass();
        studentLogin student = new studentLogin();
        public StudentLecturesandReport(string StudentName)
        {
            InitializeComponent();
            stid = studentLogin.StudentID;
            stname = studentLogin.studentName;
            studentname.Text = StudentName;
            stName = studentname.Text;
            studentid = rc.scalarReturn("select id from student where studentname ='" + stName + "'");
            //label2.Text = studentid;
        }

        private void lectures_Click(object sender, EventArgs e)
        {
           
        }

       

        

       

        studentLogin login = new studentLogin();
        private void StudentActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.DeleteStudent();
        }

        private void StudentLecturesandReport_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void StudentLecturesandReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            student.DeleteStudent();
        }

        private void StudentLecturesandReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            callforQuiz comment = new callforQuiz(studentLogin.studentName);
            // comment.getTeacherNotification();
            comment.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            StudentActivity studentActivity = new StudentActivity(stName);
            this.Hide();
            studentActivity.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            StudentActivity studentActivity = new StudentActivity(stName);
            this.Hide();
            studentActivity.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StudentReport report = new StudentReport(stName);
            this.Hide();
            report.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            StudentReport report = new StudentReport(stName);
            this.Hide();
            report.Show();
        }
       


        private void label10_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }
    }
    }
