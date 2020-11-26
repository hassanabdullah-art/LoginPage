using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class accountSetting : Form
    {


   
        public accountSetting()
        {
            InitializeComponent();
            adminname.Text = adminLogin.adminName;
        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            SendCodeToChangePassword code = new SendCodeToChangePassword();
            this.Hide();
            code.Show();
        }

        private void Changeusername_Click(object sender, EventArgs e)
        {
            adminFormChangeUserName chang = new adminFormChangeUserName();
            this.Hide();
            chang.Show();
        }

        private void changeemail_Click(object sender, EventArgs e)
        {
            adminFormChangeEmail adminemail = new adminFormChangeEmail();
            this.Hide();
            adminemail.Show();
        }

        private void accountSetting_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminForm adminForm = new adminForm();
            this.Hide();
            adminForm.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
             this.Hide();
            accountType.Show();
        }
    }
}
