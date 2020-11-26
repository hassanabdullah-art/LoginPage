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
    public partial class Teacher : Form
    {
        string name;
        teacherLogin login = new teacherLogin();

        public Teacher()
        {
            InitializeComponent();
         
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            SpacificRegisteredStudent.DataSource = GetSpecificStudent();
                  
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
        private void Teacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.DeleteTeacher();

        }

        private void Teacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
            
        }
        // send comment to students
        private void sendcomment_Click(object sender, EventArgs e)
        {
            string costring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection con = new SqlConnection(costring);
            SqlCommand cmd = new SqlCommand("usp_SendNotification", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@notification", SqlDbType.NVarChar, 50).Value = commentToClass.Text;
            cmd.Parameters.Add("@teacherName", SqlDbType.NVarChar, 50).Value = GetrecentTeacher();
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("sent notification");

        }


        string teachername;
        private string GetrecentTeacher()
        {

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            name = "select [RecentTeacher] from [dbo].[RecentTeacher]";
            SqlCommand cmd = new SqlCommand(name, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            teachername = reader["RecentTeacher"].ToString();
            reader.Close();
            conn.Close();
            return teachername;
        }



        private void logoutteacher_Click(object sender, EventArgs e)
        {
            AccountType account = new AccountType();
            this.Close();
            account.Show();

        }

        private void managenotification_Click(object sender, EventArgs e)
        {
            GridViewOfManageNotification notification = new GridViewOfManageNotification();
            notification.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherActivity activity = new TeacherActivity();
            this.Close();
            activity.Show();
        }
    }
   
}
