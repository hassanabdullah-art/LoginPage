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
    public partial class TeacherviewStudents : Form
    {
       

        public TeacherviewStudents()
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
            //lo.DeleteTeacher();

        }

        

        private void Teacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
            
        }

        private void logoutteacher_Click(object sender, EventArgs e)
        {
            AccountType form = new AccountType();
            this.Hide();
            form.Show();
        }
    }
   
}
