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
    public partial class intro_to_computer_software_and_hardware : Form
    {
        string studentName;
        public static string stName;
        string studentid;
        int stid;
        public static string topicname;
        
        string topicid;
        //string stname;
        returnclass rc = new returnclass();
        public intro_to_computer_software_and_hardware(string stname)
        {
            InitializeComponent();
            studname.Text = stname;
            studentName = studname.Text;
            stid = studentLogin.StudentID;
            stName = studentLogin.studentName;
            topicname = topic.Text;
            studentid = rc.scalarReturn("select id from student where studentname ='" + stName + "'");
            topicid = rc.scalarReturn("select topic_id from Topic where topic_name ='" + topic.Text + "'");
            //label1.Text = topicid; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void practice_Click(object sender, EventArgs e)
        {
           
        }

      /*  private void evaluation_Click(object sender, EventArgs e)
        {
           string ID = rc.scalarReturn("select stu_id_fk from set_quiz where stu_id_fk ='" + studentid + "'");
            //label2.Text = ID;
            string val = rc.scalarReturn("select studentName from student where id=" + ID);
           //topic.Text = val;
            if (val == stName)
            {
                Quiz quiz = new Quiz(topicid);
                this.Hide();
                quiz.Show();
            }
            else
            {
                MessageBox.Show("You have no quiz");
            }

        }*/

        private void computersoftwareandhardware_Click(object sender, EventArgs e)
        {
           
        }

        
        private void IntrotoComputer_Click(object sender, EventArgs e)
        {
            
        }

        private void computerworks_Click(object sender, EventArgs e)
        {
           
        }

        private void componentsofsystemunit_Click(object sender, EventArgs e)
        {
           
        }

        private void intro_to_computer_software_and_hardware_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StudentLecturesandReport lecturesandReport = new StudentLecturesandReport(studentName);
            this.Hide();
            lecturesandReport.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ComponentsOfSystemUnit components = new ComponentsOfSystemUnit();
            this.Hide();
            components.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            IntrotoComputer intro = new IntrotoComputer();
            this.Hide();
            intro.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            VideoComputeHardware computeHardware = new VideoComputeHardware();
            this.Hide();
            computeHardware.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            VideoComputeHardware computeHardware = new VideoComputeHardware();
            this.Hide();
            computeHardware.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Student_view_Video view_Video = new Student_view_Video();
            this.Hide();
            view_Video.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Student_view_Video view_Video = new Student_view_Video();
            this.Hide();
            view_Video.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            IntrotoComputer intro = new IntrotoComputer();
            this.Hide();
            intro.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ComponentsOfSystemUnit components = new ComponentsOfSystemUnit();
            this.Hide();
            components.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PracticeExercise ex = new PracticeExercise(studentName);
            this.Hide();
            ex.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            PracticeExercise ex = new PracticeExercise(studentName);
            this.Hide();
            ex.Show();
        }
  private void label10_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
        }

       
    }
}
