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
    public partial class AddTeacherForm : Form
    {
       // string name;
        public AddTeacherForm()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
            
        }
        public string teachername;
        private int teacherId = 0;
        public int TeacherId
        {
            get { return teacherId; }
            set
            {
                teacherId = value;
            }
        }

        //isupdate

        private bool isUpdate = false;
        public bool IsUpdate
        {
            get
            {
                return isUpdate;
            }
            set { isUpdate = value; }
        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                UpdateTeacher();

            }
            else
            {
                InsertTeacher();

            }
        }

        private void UpdateTeacher()
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("[dbo].[usp_UpdateTeacher]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            System.Text.RegularExpressions.Regex isemailValid = new System.Text.RegularExpressions.Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            System.Text.RegularExpressions.Regex iscnicValid = new System.Text.RegularExpressions.Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            System.Text.RegularExpressions.Regex isphoneValid = new System.Text.RegularExpressions.Regex(@"^([0-9]{4}-[0-9]{7})|(([+]{1})+[0-9]{11})");
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
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = emailId.Text;
                }
            }
               
            if (cnic.Text.Length > 0)
            {
                if (!iscnicValid.IsMatch(cnic.Text))
                {
                    MessageBox.Show("Invalid CNIC entered");
                    cnic.SelectAll();
                    cnic.Clear();
                    return;
                }
                else
                {
                    cmd.Parameters.Add("@cnic", SqlDbType.NVarChar, 15).Value = cnic.Text;
                }
            }
                
          if (phone.Text.Length > 0)
            {
                if (!isphoneValid.IsMatch(phone.Text))
                {
                    MessageBox.Show("Invalid Phone entered");
                    phone.SelectAll();
                    phone.Clear();
                    return;
                }
                else
                {
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 15).Value = phone.Text;
                }
            }
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = userName.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password.Text;
                    cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 15).Value = getGender();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = teacherId;
                    cmd.Parameters.Add("@teachername", SqlDbType.NVarChar, 50).Value = teacherName.Text;
                    cmd.Parameters.Add("@qualification", SqlDbType.NVarChar, 25).Value = qualification.Text;
                  //  cmd.Parameters.Add("@class", SqlDbType.NVarChar, 10).Value = ClasscomboBox.Text;
                   // cmd.Parameters.Add("@section", SqlDbType.NVarChar, 10).Value = SectioncomboBox.Text;
                     cmd.Parameters.AddWithValue("@photo", SavePhoto());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher updated");
                    teachername = teacherName.Text;

            
        }

            private void InsertTeacher()
            {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("usp_Addteacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            System.Text.RegularExpressions.Regex isemailValid = new System.Text.RegularExpressions.Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            System.Text.RegularExpressions.Regex iscnicValid = new System.Text.RegularExpressions.Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            System.Text.RegularExpressions.Regex isphoneValid = new System.Text.RegularExpressions.Regex(@"^([0-9]{4}-[0-9]{7})|(([+]{1})+[0-9]{11})");
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
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = emailId.Text;
                }
                if (cnic.Text.Length > 0)
                {
                    if (!iscnicValid.IsMatch(cnic.Text))
                    {
                        MessageBox.Show("Invalid CNIC entered");
                        cnic.SelectAll();
                        cnic.Clear();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.Add("@cnic", SqlDbType.NVarChar, 15).Value = cnic.Text;
                    }
                }
               
                if (phone.Text.Length > 0)
                {
                    if (!isphoneValid.IsMatch(phone.Text))
                    {
                        MessageBox.Show("Invalid Phone entered");
                        phone.SelectAll();
                        phone.Clear();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 15).Value = phone.Text;
                    }
                }
                
            
                        cmd.Parameters.Add("@teachername", SqlDbType.NVarChar, 50).Value = teacherName.Text;
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = userName.Text;
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 15).Value = getGender();
                        cmd.Parameters.Add("@qualification", SqlDbType.NVarChar, 25).Value = qualification.Text;
                       // cmd.Parameters.Add("@class", SqlDbType.NVarChar, 10).Value = ClasscomboBox.Text;
                        //cmd.Parameters.Add("@section", SqlDbType.NVarChar, 10).Value = SectioncomboBox.Text;
                      cmd.Parameters.AddWithValue("@photo", SavePhoto());


                conn.Open();
                        cmd.ExecuteNonQuery(); 
                        MessageBox.Show("Teacher added");


            }
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            Teacherpicture.Image.Save(ms, Teacherpicture.Image.RawFormat);
            return ms.GetBuffer();
        }



       

       
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
            MessageBox.Show("Selectgender");
            return "";
                
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            //load TEACHER data TO GRIDVIEW........
            if (this.IsUpdate)
            {
                DataTable teacherTable = LoadTeacherdata(this.TeacherId);
                DataRow row = teacherTable.Rows[0];
                teacherName.Text = row["teachername"].ToString();
                cnic.Text = row["cnic"].ToString();

                userName.Text =         row["username"].ToString();
                password.Text =         row["password"].ToString();
                emailId.Text =          row["email"].ToString();
                phone.Text =            row["phone"].ToString();
                qualification.Text =    row["qualification"].ToString();
                
                male.Checked =          (row["gender"] is DBNull) ? false : (Convert.ToString(row["gender"]) == "Male") ? true : false;
                female.Checked =        (row["gender"] is DBNull) ? false : (Convert.ToString(row["gender"]) == "Female") ? true : false;
               // ClasscomboBox.Text =    row["class"].ToString();
                //SectioncomboBox.Text =  row["section"].ToString();

                Teacherpicture.Image = GetImage((byte[])row["Photo"]);
            }


        }

        private Image GetImage(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private DataTable LoadTeacherdata(int studentId)
        {
            DataTable teacherdata = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("[dbo].[usp_LoadTeacherDatafromGridviewToStudentForm]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = studentId;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            teacherdata.Load(reader);
            return teacherdata;

        }

        private void back_Click(object sender, EventArgs e)
        {
            GridviewOfTeacher gridviewOfTeacher = new GridviewOfTeacher();
            this.Hide();
            gridviewOfTeacher.Show();
        }

        private void userName_MouseHover(object sender, EventArgs e)
        {
            userName.Text = cnic.Text;
        }

        private void password_MouseHover(object sender, EventArgs e)
        {
            password.Text = cnic.Text;
        }

        private void Teacherpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select profile image";
            // ofd.Filter = "PNG File (*.png)|*.png|JPG File (*.jpg)|*.jpg|BMP File (*.bmp)|*.bmp|Gif File (*.gif)|*.gif";
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Teacherpicture.Image = new Bitmap(ofd.FileName);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            adminLogin admin = new adminLogin();
            this.Hide();
            admin.Show();
        }
    }
    }

