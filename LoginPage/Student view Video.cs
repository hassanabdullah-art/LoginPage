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
    public partial class Student_view_Video : Form
    {
        public string stname;
        public Student_view_Video()
        {
            InitializeComponent();
            studentname.Text = studentLogin.studentName;
            stname = studentname.Text;
        }

        private void Student_view_Video_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = @"Videos\How Computer Works.mp4";
        }

       

        private void Student_view_Video_Load_1(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            intro_to_computer_software_and_hardware intro_To_Computer_Software_And_ = new intro_to_computer_software_and_hardware(stname);
            this.Close();
            intro_To_Computer_Software_And_.Show();
        }
    }
}

