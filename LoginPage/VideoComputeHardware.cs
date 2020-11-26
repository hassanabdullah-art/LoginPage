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
    public partial class VideoComputeHardware : Form
    {
        public string stname;
        public VideoComputeHardware()
        {
            InitializeComponent();
            studentname.Text = studentLogin.studentName;
            stname = studentname.Text;
        }

        private void VideoComputeHardware_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = @"Videos\Computer and Hardware.mp4";
        }

        private void back_Click(object sender, EventArgs e)
        {
            intro_to_computer_software_and_hardware intro_To_Computer_Software_And_Hardware = new intro_to_computer_software_and_hardware(stname);
            this.Hide();
            intro_To_Computer_Software_And_Hardware.Show();
        }
    }
}
