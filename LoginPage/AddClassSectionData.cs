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
    public partial class AddClassSectionData : Form
    {
       
        SqlConnection conn;
        StudentForm stu = new StudentForm();
       // AddSectionAndClass addsec = new AddSectionAndClass();
       // int classsectionId;
        public AddClassSectionData()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }
      
        //LoadSectionClassDatafromGridviewToStudentForm............
        private DataTable LoadSectionClassData(int classsectionId)
        {
            
            DataTable studentData = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("[dbo].[usp_LoadClassSectionDataFromGridview]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = classsectionId;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            studentData.Load(reader);
            return studentData;

        }


        private void GridviewofClassSectionData_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            LoadData();
           
        }

        private void LoadData()
        {
            
            sectionGridView.DataSource = GetClassSectionData();
            classStu.DataSource = stu.GetClassAndSectionComboboxData(3);
            classStu.DisplayMember = "Description";
            classStu.SelectedIndex = 1;
        }

        private DataTable GetClassSectionData()
        {
           
            DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            conn = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("[dbo].[usp_GetAllClassSectionDataGridView]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);       
            return table;
         
        }
        int selectedid = 0;

        private void sectionGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = e.RowIndex;
        }
        
        private void sectionGridView_DoubleClick(object sender, EventArgs e)
        {
            
            //int rowToUpdate = sectionGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
          
        }

        private void DeleteSection_Click(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            //for admin authentication
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from AddClassAndSection where id=" + sectionGridView.Rows[selectedid].Cells["id"].Value;
            cmd.ExecuteNonQuery();
            conn.Close();
            sectionGridView.Rows.RemoveAt(selectedid);
            MessageBox.Show("Deleted");
            sectionStu.Clear();
            classStu.ResetText();
        }

        private void updateSection_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            this.Hide();
            admin.Show();
        }

        private void addClassAndSection_Click(object sender, EventArgs e)
        {
           
                AddClassAndSection();
            
        }
        //UPDATE STUDENT..........
        private void UpdateSection()
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            //for admin authentication
            SqlCommand cmd = new SqlCommand("usp_UpdateSection", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = sectionGridView.Rows[selectedid].Cells["id"].Value;
            cmd.Parameters.Add("@section", SqlDbType.NVarChar, 50).Value = sectionStu.Text;
            cmd.Parameters.Add("@class", SqlDbType.NVarChar, 10).Value = classStu.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information Updated");


        }

        //ADD CLASS AND SECTION........
        public void AddClassAndSection()
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("usp_AddClassAndSection", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@class", SqlDbType.NVarChar, 10).Value = classStu.Text;
            cmd.Parameters.Add("@section", SqlDbType.NVarChar, 50).Value = sectionStu.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information Added");
            LoadData();
            classStu.ResetText();
            sectionStu.Clear();
        }

        private void sectionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = sectionGridView.Rows[e.RowIndex];

            sectionStu.Text = row.Cells[2].Value.ToString();
            classStu.Text = row.Cells[1].Value.ToString();
           

        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateSection();
            DataGridViewRow newDataRow = sectionGridView.Rows[selectedid];
            newDataRow.Cells[2].Value = sectionStu.Text;
            newDataRow.Cells[1].Value = classStu.Text;

        }

        private void back_Click(object sender, EventArgs e)
        {
            adminForm adminForm = new adminForm();
            this.Hide();
            adminForm.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }
    }
}
