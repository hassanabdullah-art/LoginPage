using System;
using System.Collections;
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
    public partial class GridviewOfStudentData : Form
    {
       // SqlDataReader reader;
        SqlConnection conn;
        StudentForm stu = new StudentForm();
        int studentId;
        public GridviewOfStudentData()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }

        private void GridviewOfStudentData_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            studentGridView.DataSource = GetStudentData();
            styleGridview();



        }

        private void styleGridview()
        {
            studentGridView.BorderStyle = BorderStyle.None;
            studentGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(234, 253, 143);
            studentGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            studentGridView.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            studentGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            studentGridView.BackgroundColor = Color.FromArgb(132, 143, 158);
            studentGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            studentGridView.EnableHeadersVisualStyles = false;
            studentGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            studentGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 15);
            studentGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 43, 67);
            studentGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            studentGridView.Font = new Font("Comic Sans MS", 14);


        }


        private DataTable GetStudentData()
        {

            DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            conn = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("[dbo].[usp_GetAllStudentDataGridView]",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }

        int selectedid = 0;
        private void studentGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            selectedid = e.RowIndex;
        }

        private void studentGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowToUpdate = studentGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
             studentId = Convert.ToInt16(studentGridView.Rows[rowToUpdate].Cells["id"].Value);

           
            stu.StudentId = studentId;
            stu.IsUpdate = true;
            stu.ShowDialog();
            studentGridView.DataSource = GetStudentData();





        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            //for admin authentication
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from student where id="+studentGridView.Rows[selectedid].Cells["id"].Value;

            cmd.ExecuteNonQuery();
            conn.Close();
            studentGridView.Rows.RemoveAt(selectedid);
            MessageBox.Show("Deleted");

        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatestudent_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            this.Hide();
            admin.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
        }

        private void addNewStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.Show();
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            DataTable dt = new DataTable();

            if (searchcombobox.Text == "Name")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where studentName like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;

            }
            else if (searchcombobox.Text == "Guardian")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where guardianName like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;

            }
            else if (searchcombobox.Text == "Registration No")
            {
                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where regNo like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;
            }

            else if (searchcombobox.Text == "Email Address")
            {


                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where emailId like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;
            }

            else if (searchcombobox.Text == "Gender")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where gender like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;

            }
            else if (searchcombobox.Text == "Age")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where age like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;
            }
            else if (searchcombobox.Text == "Teacher")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where teacher like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;
            }
            else if (searchcombobox.Text == "Class")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where class like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;
            }
            else if (searchcombobox.Text == "Section")
            {

                SqlDataAdapter sdq = new SqlDataAdapter("select studentName,guardianName,regNo,userName,password,emailId,gender,age,relation,teacher,class,section from student where section like '%" + search.Text + "%'", conn);
                sdq.Fill(dt);
                studentGridView.DataSource = dt;
            }


        }
    }
    } 

    
