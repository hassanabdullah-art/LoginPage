using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace LoginPage
{
    public partial class ForgotPasswordResetPass : Form
    {
        string emailed = ForgotPasswordSendcode.to;
            
        
      

        public ForgotPasswordResetPass()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }

        private void reset_Click(object sender, EventArgs e)
           
        {
            if(newpass.Text == confirmnewpass.Text)
            {
                string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[login] set [password] = '" + confirmnewpass.Text + "'WHERE email = '" +emailed+ "'" , conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Reseted Password");

            }
            else
            {
                MessageBox.Show("Do not matched");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            ForgotPasswordSendcode admin = new ForgotPasswordSendcode();
            this.Hide();
            admin.Show();

        }

        private void ForgotPasswordResetPass_Load(object sender, EventArgs e)
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
