using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class SendCodeToChangePassword : Form
    {

        public static string to;
        string from, pass, messageBody;

        string randomCode;


        private void varifycodebtn_Click(object sender, EventArgs e)
        {
            if (randomCode == (code.Text).ToString())
            {
                to = email.Text;
                adminFormChangePassword chngpass = new adminFormChangePassword();
                this.Hide();
                chngpass.Show();
            }
            else
            {
                MessageBox.Show("Wrong code");
            }
        }

        private void SendCodeToChangePassword_Load(object sender, EventArgs e)
        {
            adminname.Text = adminLogin.adminName;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void back_Click(object sender, EventArgs e)
        {
            accountSetting accountSetting = new accountSetting();
            this.Hide();
            accountSetting.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();

            this.Hide();
            accountType.Show();
        }

        public SendCodeToChangePassword()
        {
            InitializeComponent();
        }

        private void sendCodebtn_Click(object sender, EventArgs e)
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

            from = "faizansarwar.bs@gmail.com";
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
    }
}
