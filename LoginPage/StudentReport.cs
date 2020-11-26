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
    public partial class StudentReport : Form
    {
        string stName;
        string studentid;
        int stid;
        string stname;
        SqlConnection conn;
        string studentName;
        public StudentReport(string StudentName)
        {
            InitializeComponent();
            stid = studentLogin.StudentID;
            stname = studentLogin.studentName;
            studentNamehere.Text = StudentName;
            stName = studentNamehere.Text;

            // studentName = studentname;
            //username.Text = studentName;
            GetStudentReport();
            LoadData();
        }

        private DataTable GetStudentReport()
        {

            DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            conn = new SqlConnection(connstring);

           // string connString = @"your connection string here";
            string query = "select Topic,Total,Correct,Incorrect,Score from Report where Studentname = '"+ studentName +"'";

            //SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(table);
            conn.Close();
            da.Dispose();
            //SqlDataReader reader = cmd.ExecuteReader();
            //table.Load(da);
            return table;
        }

        private DataTable GetStudentData()
        {

            DataTable dtChartData = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            conn = new SqlConnection(connstring);

            // string connString = @"your connection string here";
            string query = "select Topic,Score from Report where Studentname = '" + studentName + "'";

            //SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dtChartData);
            conn.Close();
            da.Dispose();
            //SqlDataReader reader = cmd.ExecuteReader();
            //table.Load(da);
            return dtChartData;
        }

     



        private void StudentReport_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            studentreportdataGridView.DataSource = GetStudentReport();
            styleGridview();
            LoadData();

        }

        private void styleGridview()
        {
            studentreportdataGridView.BorderStyle = BorderStyle.None;
            studentreportdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(234, 253, 143);
            studentreportdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            studentreportdataGridView.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            studentreportdataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            studentreportdataGridView.BackgroundColor = Color.FromArgb(132, 143, 158);
            studentreportdataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            studentreportdataGridView.EnableHeadersVisualStyles = false;
            studentreportdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            studentreportdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 18);
            studentreportdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32,43,67);
            studentreportdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            studentreportdataGridView.Font = new Font("Comic Sans MS", 16);
            

        }

        


        private void LoadData()
        {
            chart1.DataSource = GetStudentData();
            chart1.Series["Score"].XValueMember = "Topic";
            chart1.Series["Score"].YValueMembers = "Score";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StudentLecturesandReport lecturesandReport = new StudentLecturesandReport(studentName);
            this.Hide();
            lecturesandReport.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();

        }
    }
}
