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
    public partial class adminForm : Form
    {
        public adminForm()
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

        private void logout_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType();
            this.Hide();
            accountType.Show();
        }

        private void changeemail_Click(object sender, EventArgs e)
        {
            adminFormChangeEmail adminemail = new adminFormChangeEmail();
            this.Hide();
            adminemail.Show();

        }

        private void managestu_Click(object sender, EventArgs e)
        {
            GridviewOfStudentData grid = new GridviewOfStudentData();
            this.Hide();
            grid.Show();

        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm teacherForm = new AddTeacherForm();
            this.Hide();
            teacherForm.Show();
        }

        private void manageteacher_Click(object sender, EventArgs e)
        {
            GridviewOfTeacher teacher = new GridviewOfTeacher();
            this.Hide();
            teacher.Show();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            StudentForm student = new StudentForm();
            this.Hide();
            student.Show();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            /*int wi = Screen.PrimaryScreen.Bounds.Width;
            int hi = Screen.PrimaryScreen.Bounds.Height;
            panel4.Location = new Point(0, 0);
            panel4.Size = new Size(wi, hi);*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AssignTeacherToClassAndSection assign = new AssignTeacherToClassAndSection();
            this.Hide();
            assign.Show();
        }

        private void manageClass_Click(object sender, EventArgs e)
        {
            AddClassSectionData sec = new AddClassSectionData();
            this.Hide();
            sec.Show();

        }

        private void manageassignedteacher_Click(object sender, EventArgs e)
        {
           // GridViewOfAssignTeacherToClassSection teacher = new GridViewOfAssignTeacherToClassSection();
            this.Hide();
           // teacher.Show();
        }

        private void manageStudent_Click(object sender, EventArgs e)
        {
            GridviewOfStudentData studentData = new GridviewOfStudentData();
            this.Hide();
            studentData.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridviewOfTeacher gridviewOfTeacher = new GridviewOfTeacher();
            this.Hide();
            gridviewOfTeacher.Show();
        }

        private void manageClassSection_Click(object sender, EventArgs e)
        {
            AddClassSectionData gridviewofClassSectionData = new AddClassSectionData();
            this.Hide();
            gridviewofClassSectionData.Show();
        }

        private void managementAssignTeacher_Click(object sender, EventArgs e)
        {
            AssignTeacherToClassAndSection assignTeacherToClassAndSection = new AssignTeacherToClassAndSection();
            this.Hide();
            assignTeacherToClassAndSection.Show();
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GridviewOfStudentData studentData = new GridviewOfStudentData();
            this.Hide();
            studentData.Show();
        }

        private void studentManagement_Click(object sender, EventArgs e)
        {
            GridviewOfStudentData studentData = new GridviewOfStudentData();
            this.Hide();
            studentData.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GridviewOfTeacher gridviewOfTeacher = new GridviewOfTeacher();
            this.Hide();
            gridviewOfTeacher.Show();
        }

        private void teacherManagement_Click(object sender, EventArgs e)
        {
            GridviewOfTeacher gridviewOfTeacher = new GridviewOfTeacher();
            this.Hide();
            gridviewOfTeacher.Show();
        }

        private void Classsectionmanagment_Click(object sender, EventArgs e)
        {
            AddClassSectionData gridviewofClassSectionData = new AddClassSectionData();
            this.Hide();
            gridviewofClassSectionData.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AddClassSectionData gridviewofClassSectionData = new AddClassSectionData();
            this.Hide();
            gridviewofClassSectionData.Show();
        }

        private void Assignteachermanagement_Click(object sender, EventArgs e)
        {
            AssignTeacherToClassAndSection assignTeacherToClassAndSection = new AssignTeacherToClassAndSection();
            this.Hide();
            assignTeacherToClassAndSection.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AssignTeacherToClassAndSection assignTeacherToClassAndSection = new AssignTeacherToClassAndSection();
            this.Hide();
            assignTeacherToClassAndSection.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            accountSetting setting = new accountSetting();
            this.Hide();
            setting.Show();
        }

        private void manageAccount_Click(object sender, EventArgs e)
        {
            accountSetting setting = new accountSetting();
            this.Hide();
            setting.Show();
        }

        private void backpictureBox_Click(object sender, EventArgs e)
        {
            adminLogin admin = new adminLogin();
            this.Hide();
            admin.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
