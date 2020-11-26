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
    public partial class teacherLogin : Form
    {

        public static string teacherName;
        public static int TeacherID;
        public teacherLogin()
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
                        String q = "select teacher_id,teachername from Teacher where username = '" + userName.Text + "'";

                        com = new SqlCommand(q, conn);

                        SqlDataReader reader = com.ExecuteReader();


                        reader.Read();
                        teacherName = reader["teachername"].ToString();
                        TeacherID = Convert.ToInt32(reader["teacher_id"].ToString());

                        reader.Close();



                        conn.Close();
                        TeacherActivity teacher = new TeacherActivity();
                        this.Hide();
                        teacher.Show();

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


            SqlCommand cmd = new SqlCommand("usp_CheckIsTeacherCorrect", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            //output parameter
            cmd.Parameters.Add("@isUserNameCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@isPasswordCorrect", SqlDbType.Bit).Direction =ParameterDirection.Output ;
            //parameter
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = userName.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password.Text;
            cmd.ExecuteNonQuery();
            isUserNameCorrect = (bool)cmd.Parameters["@isUserNameCorrect"].Value;
            isPasswordCorrect= (bool)cmd.Parameters["@isPasswordCorrect"].Value;
            DeleteTeacher();
            loadTecher();

         
            conn.Close();
        }

       

       

        public void loadTecher()
        {
            //DataTable dt = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            string q = "insert into RecentTeacher select Teacher.teachername from Teacher where Teacher.username= '" + userName.Text + "'";
            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataSet set = new DataSet();
            ad.Fill(set);

        }
        //for delete recent table recently row

        public void DeleteTeacher()
        {
            //DataTable dt = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd1 = new SqlCommand("[dbo].[usp_ResentTeacher]", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader read = cmd1.ExecuteReader();
            // MessageBox.Show("deleted");
            conn.Close();
        }

        private void teacherLogin_Load(object sender, EventArgs e)
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
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            logedin();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            logedin();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }
    }
}
