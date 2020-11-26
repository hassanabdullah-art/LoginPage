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
    public partial class callforQuiz : Form
    {
        
        int stid;
        string stname;
        returnclass rc = new returnclass();
        studentLogin student = new studentLogin();
        public callforQuiz(string StudentName)
        {
            
            InitializeComponent();
            stname = studentLogin.studentName;
            studentname.Text = StudentName;
        }

        private void callforQuiz_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            showcommentGrid.DataSource = getTeacherNotification();
        }
        private DataTable getTeacherNotification()
        {
            DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("usp_viewNotificationGridview", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }

        

        private void showcommentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           StudentLecturesandReport student = new StudentLecturesandReport(studentLogin.studentName);
           this.Hide();
           student.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
        }
    }
}
