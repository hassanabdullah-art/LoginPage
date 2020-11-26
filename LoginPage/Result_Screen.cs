using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Result_Screen : Form
    {
        int percentage;
        string studentname;
        public Result_Screen(string topic, string studname,int total, int correctanswer, int incorrect, int score)
        {
            InitializeComponent();


            lbltotal.Text = total.ToString();

            lblcorrect.Text = correctanswer.ToString();

            lblincorrect.Text = incorrect.ToString();

            percentage = (int)Math.Round((double)(score * 100) / total);

            lblscore.Text = percentage + "%";

            studentname = studname;


            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("usp_Reporting", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TopicName", SqlDbType.NVarChar, 50).Value = topic.ToString();
            cmd.Parameters.Add("@Total", SqlDbType.Int).Value = total.ToString();
            cmd.Parameters.Add("@Correct", SqlDbType.Int).Value = correctanswer.ToString();
            cmd.Parameters.Add("@Incorrect", SqlDbType.Int).Value = incorrect.ToString();
            cmd.Parameters.Add("@Score", SqlDbType.Float).Value = score.ToString();
            cmd.Parameters.Add("@Studentname", SqlDbType.NVarChar, 50).Value = studname.ToString();
            //cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentid.ToString();

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("store score");



        }

        private void submit_Click(object sender, EventArgs e)
        {
            intro_to_computer_software_and_hardware intro_To_Computer_Software_And_Hardware = new intro_to_computer_software_and_hardware(studentname);
            //StudentReport report = new StudentReport(studentname);
            this.Hide();
            intro_To_Computer_Software_And_Hardware.Show();
        }

        private void Result_Screen_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
