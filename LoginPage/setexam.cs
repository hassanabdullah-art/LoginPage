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
    public partial class setexam : Form
    {
        public static int teacherid;
        public string tname;
        public int time;
        SqlConnection conn;
        returnclass rc = new returnclass();
        public setexam()
        {
            InitializeComponent();
            GetTopicName();
            GetSetExamData();
            teacherid = teacherLogin.TeacherID;
            teachername.Text = teacherLogin.teacherName;
            tname = teachername.Text;
            //time = Convert.ToInt32(timecomboBox.SelectedItem.ToString());
        }

        private void setexam_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            SpecificRegisteredStudent.DataSource = GetSpecificStudent();
            LoadData();
        }

        private void LoadData()
        {
            addexam.DataSource = GetSetExamData();
        }

        private DataSet GetTopicName()
        {

            //DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            conn = new SqlConnection(connstring);

            // string connString = @"your connection string here";
            string query = "select * from Topic";

            //SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            // this will query your database and return the result to your datatable
            da.Fill(dataSet);
            examnamecombobox.DataSource = dataSet.Tables[0];
            examnamecombobox.DisplayMember = "topic_name";
            examnamecombobox.ValueMember = "topic_id";
            conn.Close();
            da.Dispose();
            //SqlDataReader reader = cmd.ExecuteReader();
            //table.Load(da);
            return dataSet;
        }


        private DataTable GetSpecificStudent()
        {

            DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("usp_GetRegisteredStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;

        }

        private void add_Click(object sender, EventArgs e)
        {
            //DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("usp_SET_Quiz", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@std_id_fk", SqlDbType.Int).Value = Convert.ToInt32(stid.Text);
            cmd.Parameters.Add("@topic_id_fk", SqlDbType.Int).Value = examnamecombobox.SelectedValue.ToString();
            cmd.Parameters.Add("@time", SqlDbType.Int).Value = timecomboBox.SelectedItem.ToString();

            conn.Open();
            cmd.ExecuteNonQuery();
            LoadData();
            //table.Load(reader);
            //return table;
        }

        private DataTable GetSetExamData()
        {

            DataTable table = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            string query = "Select * from set_quiz";
            SqlConnection conn = new SqlConnection(connstring);


            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;

        }
        private void back_Click(object sender, EventArgs e)
        {
            ManageQuiz manage = new ManageQuiz();
            this.Hide();
            manage.Show();
        }

        private void send_Click(object sender, EventArgs e)
        {
            
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("usp_SET_Quiz", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int id = Convert.ToInt32(rc.scalarReturn("Select id from student where teacher= '" + teacherLogin.teacherName + "'"));
            cmd.Parameters.Add("@std_id_fk", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@topic_id_fk", SqlDbType.Int).Value = examnamecombobox.SelectedValue.ToString();
            cmd.Parameters.Add("@time", SqlDbType.Int).Value = timecomboBox.SelectedItem.ToString();

            conn.Open();
            cmd.ExecuteNonQuery();
            this.Hide();
            this.Show();
        }

    }
}
