using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;

namespace LoginPage
{
    public partial class ForgotPasswordSendcode : Form
    {
        public static string to;
        string from, pass, messageBody;

        string randomCode;                    


        public ForgotPasswordSendcode()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }

        private void sendcode_Click(object sender, EventArgs e)
        {
            
            SendcodeViaEmail();
        }

        private void ForgotPasswordSendcode_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminLogin admin = new adminLogin();
            this.Hide();
            admin.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }

        public void SendcodeViaEmail()
        {
          
            

        Random randomClass = new Random();
                randomCode = (randomClass.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstring);
                string queryForMatchEmail = "Select email from [dbo].[login] where email = '" + email.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryForMatchEmail, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    to = (email.Text).ToString();

                }
                else
                {
                    MessageBox.Show("Incorrect Email");
                    return;
                }

                from = "Faizansarwar.bs@gmail.com";
                pass = "Allah-hu-akbar";
                messageBody = "your reset code is " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Resetting Password Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        

        private void verify_Click(object sender, EventArgs e)
        {
            if(randomCode==(code.Text).ToString())
            {
                to = email.Text;
                ForgotPasswordResetPass respass = new ForgotPasswordResetPass();
                this.Hide();
                respass.Show();
            }
            else
            {
                MessageBox.Show("Wrong code");
            }
        }
    }
}
