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
    public partial class GridviewOfTeacher : Form
    {
        AddTeacherForm teach = new AddTeacherForm();
        int teacherId;
        SqlConnection conn;
        public GridviewOfTeacher()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }

        private void teacherGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowToUpdate = teacherGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            teacherId = Convert.ToInt16(teacherGridView.Rows[rowToUpdate].Cells["id"].Value);


            teach.TeacherId = teacherId;
            teach.IsUpdate = true;
            teach.ShowDialog();
            teacherGridView.DataSource = GetTeacherdata();
        }


        private DataTable GetTeacherdata()
        {

            DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            conn = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("[dbo].[usp_GetAllTeacherDataGridView]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }
        int selectedid = 0;
        private void teacherGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = e.RowIndex;
        }

        private void deleteteacher_Click(object sender, EventArgs e)
        {

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            //for admin authentication
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from Teacher where teacher_id=" + teacherGridView.Rows[selectedid].Cells["id"].Value;

            cmd.ExecuteNonQuery();
            conn.Close();
            teacherGridView.Rows.RemoveAt(selectedid);
            MessageBox.Show("Deleted");
        }

        private void GridviewOfTeacher_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            teacherGridView.DataSource = GetTeacherdata();
            styleGridview();
        }



        private void styleGridview()
        {
            teacherGridView.BorderStyle = BorderStyle.None;
            teacherGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(234, 253, 143);
            teacherGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            teacherGridView.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            teacherGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            teacherGridView.BackgroundColor = Color.FromArgb(132, 143, 158);
            teacherGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            teacherGridView.EnableHeadersVisualStyles = false;
            teacherGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            teacherGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 18);
            teacherGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 43, 67);
            teacherGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            teacherGridView.Font = new Font("Comic Sans MS", 16);


        }


        private void back_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            this.Hide();
            admin.Show();
        }

        private void addNewTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm teacher = new AddTeacherForm();
            this.Hide();
            teacher.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
        }

        private void backpictureBox_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            this.Hide();
            admin.Show();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            DataTable dt = new DataTable();

            if (searchcombobox.Text == "Name")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("SELECT teachername, cnic, username,password, email, qualification, gender, phone from Teacher where teachername like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                teacherGridView.DataSource = dt;

            }
            else if (searchcombobox.Text == "Phone")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("SELECT teachername, cnic, username,password, email, qualification, gender, phone from Teacher  where phone like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                teacherGridView.DataSource = dt;

            }
            else if (searchcombobox.Text == "CNIC")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("SELECT teachername, cnic, username,password, email, qualification, gender, phone from Teacher  where cnic like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                teacherGridView.DataSource = dt;
            }

            else if (searchcombobox.Text == "Email Address")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("SELECT teachername, cnic, username,password, email, qualification, gender, phone from Teacher  where email like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                teacherGridView.DataSource = dt;
            }

            else if (searchcombobox.Text == "Gender")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("SELECT teachername, cnic, username,password, email, qualification, gender, phone from Teacher  where gender like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                teacherGridView.DataSource = dt;

            }
            else if (searchcombobox.Text == "Qualification")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("SELECT teachername, cnic, username,password, email, qualification, gender, phone from Teacher  where qualification like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                teacherGridView.DataSource = dt;

            }



        }

    }
}

