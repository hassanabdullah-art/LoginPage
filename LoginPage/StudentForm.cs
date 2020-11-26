using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class StudentForm : Form
    {
        string name;

        public StudentForm()
        {
            InitializeComponent();
        }
        private int studentId = 0;
        public int StudentId
        {
            get { return studentId; }
            set
            {
                studentId = value;
            }
        }

        //isupdate

        private bool isUpdate = false;
        public bool IsUpdate
        {
            get {
                return isUpdate;
                    }
            set { isUpdate = value; }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
                  if(this.IsUpdate)
            {
                UpdatenewStudent();
            }
            else
            {
                insertNewStudent();
            }
        }

       
        //UPDATE STUDENT..........
        private void UpdatenewStudent()
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            //for admin authentication
            SqlCommand cmd = new SqlCommand("usp_UpdateStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            System.Text.RegularExpressions.Regex isemailValid = new System.Text.RegularExpressions.Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            if (emailId.Text.Length > 0)
            {
                if (!isemailValid.IsMatch(emailId.Text))
                {
                    MessageBox.Show("Invalid Email entered");
                    emailId.SelectAll();
                    emailId.Clear();
                    return;
                }
                else
                {
                    cmd.Parameters.Add("@emailId", SqlDbType.NVarChar, 50).Value = emailId.Text;
                }
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = studentId;
                    cmd.Parameters.Add("@studentName", SqlDbType.NVarChar, 50).Value = studentName.Text;
                    cmd.Parameters.Add("@guardianName", SqlDbType.NVarChar, 50).Value = guardianName.Text;
                    cmd.Parameters.Add("@regNo", SqlDbType.NVarChar, 50).Value = regNo.Text;
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value = userName.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password.Text;
                    cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 15).Value = getGender();
                    cmd.Parameters.Add("@age", SqlDbType.NVarChar, 20).Value = age.Text;
                    cmd.Parameters.Add("@relation", SqlDbType.NVarChar, 25).Value = relation.Text;
                    cmd.Parameters.Add("@class", SqlDbType.NVarChar, 10).Value = ClasscomboBoxStu.Text;
                    cmd.Parameters.Add("@section", SqlDbType.NVarChar, 10).Value = sectionComboBoxStu.Text;
                    cmd.Parameters.AddWithValue("@photo", SavePhoto());
                   // cmd.Parameters.Add("@teacher", SqlDbType.NVarChar, 50).Value = GetteacherFromCombobox();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");

            }
        }
        

        //INSERT NEW STUDENT
        private void insertNewStudent()
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("usp_studentDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            System.Text.RegularExpressions.Regex isemailValid = new System.Text.RegularExpressions.Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            if (emailId.Text.Length > 0)
            {
                if (!isemailValid.IsMatch(emailId.Text))
                {
                    MessageBox.Show("Invalid Email entered");
                    emailId.SelectAll();
                    emailId.Clear();
                    return;
                }
                else
                {
                    cmd.Parameters.Add("@emailId", SqlDbType.NVarChar, 50).Value = sectionComboBoxStu.Text;
                }

                cmd.Parameters.Add("@studentName", SqlDbType.NVarChar, 50).Value = studentName.Text;
                cmd.Parameters.Add("@guardianName", SqlDbType.NVarChar, 50).Value = guardianName.Text;
                cmd.Parameters.Add("@regNo", SqlDbType.NVarChar, 50).Value = regNo.Text;
                cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value = userName.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password.Text;
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 15).Value = getGender();
                cmd.Parameters.Add("@age", SqlDbType.NVarChar, 20).Value = age.Text;
                cmd.Parameters.Add("@relation", SqlDbType.NVarChar, 25).Value = relation.Text;
                cmd.Parameters.Add("@class", SqlDbType.NVarChar, 10).Value = ClasscomboBoxStu.Text;
                cmd.Parameters.Add("@section", SqlDbType.NVarChar, 10).Value = sectionComboBoxStu.Text;
                cmd.Parameters.AddWithValue("@photo", SavePhoto());
                cmd.Parameters.Add("@teacher", SqlDbType.NVarChar, 50).Value = GetteacherFromCombobox();
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Student added");

            }


        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            studentpicture.Image.Save(ms, studentpicture.Image.RawFormat);
            return ms.GetBuffer();
        }


        /*public void getTeacher_id()
            {
                //DataTable dt = new DataTable();
                string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstring);
                string q = "select student.teacher_id=SCOPE_IDENTITY() if exists(select Teacher.teacher_id from Teacher) insert into student(teacher_id) values(teacher_id)";
                SqlDataAdapter ad = new SqlDataAdapter(q, conn);
                DataSet set = new DataSet();
                ad.Fill(set);



            }*/

        //GENDER METHOD
        private string getGender()
        {
            if (male.Checked)
            {
                return "Male";
            }
            else if (female.Checked)
            {
                return "Female";
            }
            else
                return "null";


        }


        //TEACHER COMBOBOX
        string teachername;
          private string GetteacherFromCombobox()
           {
            
                string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstring);

                conn.Open();
                name = "select teacherName from AssignTeacherToClassAndSection where section='" + sectionComboBoxStu.Text + "' and class='" + ClasscomboBoxStu.Text + "'";
                SqlCommand cmd = new SqlCommand(name, conn);
          
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                teachername = reader["teacherName"].ToString();
                reader.Close();
                conn.Close();
           
               return teachername;
           }

        //LoadStudentDatafromGridviewToStudentForm............
        private DataTable LoadStudentData(int studentId)
        {
            DataTable studentData = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("[dbo].[usp_LoadStudentDatafromGridviewToStudentForm]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = studentId;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            studentData.Load(reader);
            return studentData;

        }
 
        private void back_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            this.Hide();
            admin.Show();
        }

        private void userName_MouseHover_1(object sender, EventArgs e)
        {
            userName.Text = regNo.Text;
        }

        private void password_MouseHover_1(object sender, EventArgs e)
        {
            password.Text = regNo.Text;
        }
        //WHEN OPEN STUDENT FORM SHOWS BELLOW DATA.......
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
        //get section
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

        private void StudentForm_Load_1(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            age.DataSource = GetClassAndSectionComboboxData(1);
            age.DisplayMember = "Description";
            age.SelectedIndex = 10;
            relation.DataSource = GetClassAndSectionComboboxData(2);
            relation.DisplayMember = "Description";
            relation.SelectedIndex = 1;
            ClasscomboBoxStu.DataSource=GetClassAndSectionComboboxData(3);
            ClasscomboBoxStu.DisplayMember = "Description";
            ClasscomboBoxStu.SelectedIndex = 1;
            sectionComboBoxStu.DataSource = GetSection();
            sectionComboBoxStu.DisplayMember = "section";
           
            // BACK STUDENT DATA TO UPDATE
            if (this.IsUpdate)
            {
                DataTable studentTable = LoadStudentData(this.StudentId);
                DataRow row = studentTable.Rows[0];
                studentName.Text = row["studentName"].ToString();
                guardianName.Text = row["guardianName"].ToString();
                regNo.Text = row["regNo"].ToString();
                userName.Text = row["userName"].ToString();
                password.Text = row["password"].ToString();
                emailId.Text = row["emailId"].ToString();
                age.Text = row["age"].ToString();
                relation.Text = row["relation"].ToString();
                //teacher.Text = row["teacher"].ToString();
                male.Checked = (row["gender"] is DBNull) ? false : (Convert.ToString(row["gender"]) == "Male") ? true : false;
                female.Checked = (row["gender"] is DBNull) ? false : (Convert.ToString(row["gender"]) == "Female") ? true : false;
                ClasscomboBoxStu.Text = row["class"].ToString();
                sectionComboBoxStu.Text = row["section"].ToString();
                studentpicture.Image = GetImage((byte[])row["Photo"]);

            }
        }

        private Image GetImage(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void studentpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select profile image";
            // ofd.Filter = "PNG File (*.png)|*.png|JPG File (*.jpg)|*.jpg|BMP File (*.bmp)|*.bmp|Gif File (*.gif)|*.gif";
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

           if(ofd.ShowDialog() == DialogResult.OK)
            {
                studentpicture.Image = new Bitmap(ofd.FileName);
            }

        }

        private void StudentForm_MouseHover(object sender, EventArgs e)
        {
           // GetteacherFromCombobox();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            GridviewOfStudentData gridviewOfStudentData = new GridviewOfStudentData();
            this.Hide();
            gridviewOfStudentData.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }
    }
}
