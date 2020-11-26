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
    public partial class CreateQuiz : Form
    {
        int totalquestions;
        int topicid;
        int teacherid;
        int quesno = 1;
        public string tname;
        public CreateQuiz(int total, int topic, int id)
        {
            InitializeComponent();
            teacherid = id;
            totalquestions = total;
            topicid = topic;
            teachername.Text = teacherLogin.teacherName;
            tname = teachername.Text;
            qnum.Text = quesno.ToString();
            //quesno++;
            question.Clear();
            optionA.Clear();
            optionB.Clear();
            optionC.Clear();
            optionD.Clear();
            CorrectAns.Clear();
        }

        public SqlCommand cmd2;

        private int studentId = 0;
        public int StudentId
        {
            get { return studentId; }
            set
            {
                studentId = value;
            }
        }

        //isupdate

        private bool isUpdate = false;
        public bool IsUpdate
        {
            get
            {
                return isUpdate;
            }
            set { isUpdate = value; }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
                quesno++;
                InsertQuiz(quesno);
        }

        //INSERT NEW STUDENT
        private void InsertQuiz(int quesno)
        {
            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("usp_CreateQuiz", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //for (int studentid = 1; studentid <= 20; studentid++)
            //{
                //qnum.Text = studentid.ToString();
                //cmd.Parameters.Add("@Questionno", SqlDbType.Int).Value = questiono.Text;
                cmd.Parameters.Add("@question", SqlDbType.NVarChar, 250).Value = question.Text;
                cmd.Parameters.Add("@optionA", SqlDbType.NVarChar, 100).Value = optionA.Text;
                cmd.Parameters.Add("@optionB", SqlDbType.NVarChar, 100).Value = optionB.Text;
                cmd.Parameters.Add("@optionC", SqlDbType.NVarChar, 100).Value = optionC.Text;
                cmd.Parameters.Add("@optionD", SqlDbType.NVarChar, 100).Value = optionD.Text;
                cmd.Parameters.Add("@correctAnswer", SqlDbType.NVarChar, 100).Value = CorrectAns.Text;
                cmd.Parameters.Add("@T_id", SqlDbType.Int).Value = teacherid;
                cmd.Parameters.Add("@Exam_id", SqlDbType.Int).Value = topicid;
            // cmd2 = new SqlCommand("select [teacher] from [student] ", conn);
            
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Quiz Added");
            question.Clear();
            optionA.Clear();
            optionB.Clear();
            optionC.Clear();
            optionD.Clear();
            CorrectAns.Clear();
            //quesno++;
            qnum.Text = quesno.ToString();
            //}
            if(quesno == totalquestions)
            {
                Insert.Text = "Create";
            }
            if(quesno == totalquestions + 1)
            {
                MessageBox.Show("Quiz Created");
            }
            conn.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            ManageQuiz manage = new ManageQuiz();
            this.Hide();
            manage.Show();
        }

        private void CreateQuiz_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
