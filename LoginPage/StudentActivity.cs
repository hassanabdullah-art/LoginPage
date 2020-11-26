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
    public partial class StudentActivity : Form
    {
        string stName;
        string studentid;
        int stid;
        string stname;
        
        public StudentActivity(string StudentName)
        {
            InitializeComponent();
          //  stid = studentLogin.StudentID;
            stname = studentLogin.studentName;
            stunamehere.Text = StudentName;
            stName = stunamehere.Text;
           // studentname.Text = StudentName;
           // stName = studentname.Text;
            //id.Text = ID;
            //studentid = id.Text;
        }

       

       

        private void StudentActivity_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StudentLecturesandReport lecturesandReport = new StudentLecturesandReport(stName);
            this.Hide();
            lecturesandReport.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            intro_to_computer_software_and_hardware topic1 = new intro_to_computer_software_and_hardware(stName);
            this.Hide();
            topic1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            intro_to_computer_software_and_hardware topic1 = new intro_to_computer_software_and_hardware(stName);
            this.Hide();
            topic1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }
    }
}
