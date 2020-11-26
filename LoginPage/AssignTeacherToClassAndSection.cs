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
    public partial class AssignTeacherToClassAndSection : Form
    {
        SqlConnection conn;
        public AssignTeacherToClassAndSection()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }

        private void assignTeacherbtn_Click(object sender, EventArgs e)
        {
                AssignTeacher();
            
        }

        private void AssignTeacher()
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            //for admin authentication
            SqlCommand cmd = new SqlCommand("usp_AssignTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@section", SqlDbType.NVarChar, 50).Value = sectionComboBox.Text;
            cmd.Parameters.Add("@class", SqlDbType.NVarChar, 10).Value = classComboBox.Text;
            cmd.Parameters.Add("@teacherName", SqlDbType.NVarChar, 50).Value = TeacherComboBox.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information added");
            LoadData();
            sectionComboBox.ResetText();
            classComboBox.ResetText();
            TeacherComboBox.ResetText();

        }

        private void UpdateAsignTeacher()
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            //for admin authentication
            SqlCommand cmd = new SqlCommand("usp_UpdateAssignTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = AsignTeacherdataGridView.Rows[selectedid].Cells["id"].Value;
            cmd.Parameters.Add("@section", SqlDbType.NVarChar, 50).Value = sectionComboBox.Text;
            cmd.Parameters.Add("@class", SqlDbType.NVarChar, 10).Value = classComboBox.Text;
            cmd.Parameters.Add("@teacherName", SqlDbType.NVarChar, 50).Value = TeacherComboBox.Text;

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information Updated");

        }
        //LoadSectionClassDatafromGridviewToStudentForm............
        private DataTable LoadAssignTeacherData(int classsectionId)
        {
            DataTable studentData = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("[dbo].[usp_LoadAssignTeacherDataFromGridview]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = classsectionId;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            studentData.Load(reader);
            return studentData;

        }


        //get teacher name combobox
        private DataTable GetteacherFromCombobox()
        {
            DataTable dt = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {


                using (SqlCommand cmd = new SqlCommand("usp_getTeachername", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }
            return dt;
        }
        //show assigend teacher
        private DataTable GetAssignTeacher()
        {
            DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            conn = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("[dbo].[usp_GetAllAssignTeacherClassSectionDataGridView]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }
        int selectedid = 0;

        // get section combobox


        public DataTable GetSection()
        {
            DataTable dt = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {


                using (SqlCommand cmd = new SqlCommand("usp_GetSectionName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }
            return dt;
        }

        public DataTable GetClassAndSectionComboboxData(int listdata)
        {
            DataTable dt = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_LoadComboboxData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ListDataType", SqlDbType.Int).Value = listdata;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }



        private void AssignTeacherToClassAndSection_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            LoadData();

            // BACK STUDENT DATA TO UPDATE
            styleGridview();



        }



        private void styleGridview()
        {
            AsignTeacherdataGridView.BorderStyle = BorderStyle.None;
            AsignTeacherdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(234, 253, 143);
            AsignTeacherdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AsignTeacherdataGridView.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            AsignTeacherdataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            AsignTeacherdataGridView.BackgroundColor = Color.FromArgb(132, 143, 158);
            AsignTeacherdataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            AsignTeacherdataGridView.EnableHeadersVisualStyles = false;
            AsignTeacherdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            AsignTeacherdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 18);
            AsignTeacherdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 43, 67);
            AsignTeacherdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            AsignTeacherdataGridView.Font = new Font("Comic Sans MS", 16);


        }



        private void LoadData()
        {
            AsignTeacherdataGridView.DataSource = GetAssignTeacher();

            classComboBox.DataSource = GetClassAndSectionComboboxData(3);
            classComboBox.DisplayMember = "Description";
            classComboBox.SelectedIndex = 1;
            TeacherComboBox.DataSource = GetteacherFromCombobox();
            TeacherComboBox.DisplayMember = "teachername";
            sectionComboBox.DataSource = GetSection();
            sectionComboBox.DisplayMember = "section";
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            this.Hide();
            admin.Show();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            //for admin authentication
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from AssignTeacherToClassAndSection where id=" + AsignTeacherdataGridView.Rows[selectedid].Cells["id"].Value;
            cmd.ExecuteNonQuery();
            conn.Close();
            AsignTeacherdataGridView.Rows.RemoveAt(selectedid);
            MessageBox.Show("Deleted");
            sectionComboBox.ResetText();
            classComboBox.ResetText();
            TeacherComboBox.ResetText();
        }

        private void AsignTeacherdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // selectedrowid = e.RowIndex;

            DataGridViewRow row = AsignTeacherdataGridView.Rows[e.RowIndex];

            sectionComboBox.Text = row.Cells[2].Value.ToString();
            classComboBox.Text = row.Cells[1].Value.ToString();
            TeacherComboBox.Text = row.Cells[3].Value.ToString();
        }
        private void update_Click(object sender, EventArgs e)
        {
            UpdateAsignTeacher();
            DataGridViewRow newDataRow = AsignTeacherdataGridView.Rows[selectedid];
            newDataRow.Cells[2].Value = sectionComboBox.Text;
            newDataRow.Cells[1].Value = classComboBox.Text;
            newDataRow.Cells[3].Value = TeacherComboBox.Text;
   
        }

        private void backpictureBox_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            this.Hide();
            admin.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
        }
    }
}
