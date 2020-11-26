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
    public partial class adminFormChangeUserName : Form
    {

        public adminFormChangeUserName()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            string queryForMatchEmail = "Select username from [dbo].[login] where username = '" + oldusername.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryForMatchEmail, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                // to = (email.Text).ToString();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[login] set [username] = '" + newusername.Text + "' where [username] ='"+oldusername.Text+"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Username");
                conn.Close();

            }
            else
            {
                MessageBox.Show("old user name not matched");
                return;
            }



           
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            accountSetting account = new accountSetting();
            this.Hide();
            account.Show();
        }

        private void adminFormChangeUserName_Load(object sender, EventArgs e)
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
