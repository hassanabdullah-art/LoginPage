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
    public partial class adminFormChangeEmail : Form
    {
        public adminFormChangeEmail()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }

        private void back_Click(object sender, EventArgs e)
        {
            accountSetting accountSetting = new accountSetting();
            this.Hide();
            accountSetting.Show();
        }

        private void UpdateEmail_Click(object sender, EventArgs e)

        {


            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            string queryForMatchEmail = "Select email from [dbo].[login] where email = '" + oldemailaddress.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryForMatchEmail, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                System.Text.RegularExpressions.Regex isemailValid = new System.Text.RegularExpressions.Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
                if (newemailaddress.Text.Length > 0)
                {
                    if (!isemailValid.IsMatch(newemailaddress.Text))
                    {
                        MessageBox.Show("Invalid Email entered");
                        newemailaddress.SelectAll();
                        newemailaddress.Clear();
                    }
                    else
                    {
                        // to = (email.Text).ToString();
                        SqlCommand cmd = new SqlCommand("UPDATE [dbo].[login] set [email] = '" + newemailaddress.Text + "' where [email] ='" + oldemailaddress.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated Email Address");
                        conn.Close();


                    }
                }


            }
            else
            {
                MessageBox.Show("old Email not matched");
                oldemailaddress.Clear();
                return;
            }
        }

        private void adminFormChangeEmail_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
        }
    }
}

