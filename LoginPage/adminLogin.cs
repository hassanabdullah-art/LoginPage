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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }
        public static string adminName;
        returnclass rc = new returnclass();
        private void login_Click(object sender, EventArgs e)
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
                        String q = "select username from login where username = '" + userName.Text + "'";

                        com = new SqlCommand(q, conn);

                        SqlDataReader reader = com.ExecuteReader();


                        reader.Read();
                        adminName = reader["username"].ToString();
                        //int adminID = Convert.ToInt32(reader["id"].ToString());

                        reader.Close();



                        conn.Close();
                        this.Hide();
                        adminForm admin = new adminForm();
                        admin.Show();
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

       

        private void GetIsUserLoginCorrect(out bool isUserNameCorrect, out bool isPasswordCorrect)
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);


            SqlCommand cmd = new SqlCommand("usp_CheckIAdminCorrect", conn);
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

        public bool IsValidated()
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

        private void label4_Click(object sender, EventArgs e)
        {
            ForgotPasswordSendcode code = new ForgotPasswordSendcode();
            this.Hide();
            code.Show();

        }

        private void adminLogin_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text == "Username")
            {
                userName.Text = "";
                userName.ForeColor = Color.Black;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "********")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void backpicturebox_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
