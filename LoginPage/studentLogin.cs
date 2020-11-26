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
    public partial class studentLogin : Form
    {
        adminLogin admin = new adminLogin();
        public static int StudentID;
        public static string studentName;
        public studentLogin()
        {
            InitializeComponent();
        }

        

        private void logedin()
        {
            if (IsValidated())
            {
                try
                {
                    bool isUserNameCorrect, IsPasswordCorrect;
                    GetIsUserLoginCorrect(out isUserNameCorrect, out IsPasswordCorrect);
                    if (isUserNameCorrect && IsPasswordCorrect)
                    {
                        string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
                        SqlCommand com;
                        SqlConnection conn = new SqlConnection(connstring);
                        conn.Open();
                        String q = "select id,studentName from student where userName = '" + userName.Text + "'";

                        com = new SqlCommand(q, conn);

                        SqlDataReader reader = com.ExecuteReader();


                        reader.Read();
                        studentName = reader["studentName"].ToString();
                        int StudentID = Convert.ToInt32(reader["id"].ToString());

                        reader.Close();



                        conn.Close();

                        StudentLecturesandReport lecturesandReport = new StudentLecturesandReport(studentName);
                        StudentActivity studentActivity = new StudentActivity(studentName);
                        intro_to_computer_software_and_hardware intro = new intro_to_computer_software_and_hardware(studentName);
                        PracticeExercise practice = new PracticeExercise(studentName);
                        StudentReport report = new StudentReport(studentName);
                        this.Hide();
                        lecturesandReport.Show();
                        loadStudent();
                    }
                    else
                    {
                        if (!isUserNameCorrect)
                        {
                            MessageBox.Show("Username is incorrect", "No User Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userName.Clear();
                            password.Clear();
                            userName.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Password is incorrect", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            password.Clear();
                            password.Focus();

                        }
                    }
                }

                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool IsValidated()
        {
            

                if (userName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Username is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userName.Clear();
                    userName.Focus();
                    return false;
                }
                if (password.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Clear();
                    password.Focus();
                    return false;
                }
                return true;

            
        }

        private void GetIsUserLoginCorrect(out bool isUserNameCorrect, out bool isPasswordCorrect)
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);


            SqlCommand cmd = new SqlCommand("usp_CheckIsStudentCorrect", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            //output parameter
            cmd.Parameters.Add("@isUserNameCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@isPasswordCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
            //parameter
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = userName.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password.Text;
            cmd.ExecuteNonQuery();
            isUserNameCorrect = (bool)cmd.Parameters["@isUserNameCorrect"].Value;
            isPasswordCorrect = (bool)cmd.Parameters["@isPasswordCorrect"].Value;
            //  DeleteTeacher();
            // loadTecher();


            conn.Close();
        }
        // load recent Student;
        public void loadStudent()
        {
            //DataTable dt = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            string q = "insert into RecentStudent select student.[studentName],student.teacher from student where student.username='" + userName.Text + "'";
            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet set = new DataSet();
            ad.Fill(set);

        }





        //for delete recent student recently row

        public void DeleteStudent()
        {
            //DataTable dt = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd1 = new SqlCommand("[dbo].[usp_ResentStudent]", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader read = cmd1.ExecuteReader();
            // MessageBox.Show("deleted");
            conn.Close();
        }

        private void studentLogin_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ForgotPasswordSendcode code = new ForgotPasswordSendcode();
            this.Hide();
            code.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
           // AccountType accountType = new AccountType();
            this.Hide();
           // accountType.Show();
            DeleteStudent();
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if(userName.Text=="Username")
            {
                userName.Text = "";
                userName.ForeColor = Color.Black;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "******")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            logedin();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            logedin();
        }

    
    }
}
