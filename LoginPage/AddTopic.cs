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
    public partial class AddTopic : Form
    {
        public static int totalquestions;
        public static int topicid;
        public static int time;
        public string tname;
        int teacherid;
        SqlConnection conn;
        public AddTopic()
        {
            InitializeComponent();
            teacherid = teacherLogin.TeacherID;
            teachername.Text = teacherLogin.teacherName;
            tname = teachername.Text;
        }

        private void next_Click(object sender, EventArgs e)
        {
            time = Convert.ToInt32(settimecomboBox.SelectedItem.ToString());
            totalquestions = Convert.ToInt32(totalquestioncombobox.SelectedItem.ToString());
            topicid =  Convert.ToInt32(topicnamecombobox.SelectedValue.ToString());
            CreateQuiz quiz = new CreateQuiz(totalquestions,topicid,teacherid);
            this.Hide();
            quiz.Show();
        }

        private void AddTopic_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            // TODO: This line of code loads data into the 'forgettPasswordDataSet1.Topic' table. You can move, or remove it, as needed.
            // this.topicTableAdapter.Fill(this.forgettPasswordDataSet1.Topic);
            GetTopicName();

        }

        private DataSet GetTopicName()
        {

            //DataTable table = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
            conn = new SqlConnection(connstring);

            // string connString = @"your connection string here";
            string query = "select * from Topic";

            //SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            // this will query your database and return the result to your datatable
            da.Fill(dataSet);
            topicnamecombobox.DataSource = dataSet.Tables[0];
            topicnamecombobox.DisplayMember = "topic_name";
            topicnamecombobox.ValueMember = "topic_id";
            conn.Close();
            da.Dispose();
            //SqlDataReader reader = cmd.ExecuteReader();
            //table.Load(da);
            return dataSet;
        }

        private void back_Click(object sender, EventArgs e)
        {
            ManageQuiz manage = new ManageQuiz();
            this.Hide();
            manage.Show();
        }

        private void LoadAllTopics()
        {
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;
                SqlCommand com;
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();
                String q = "select topic_name from Topic";

                com = new SqlCommand(q, conn);
                //Execute the command to read multiple values use ExecuteReader for one value use ExecuteScaler
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    topicnamecombobox.Items.Add(reader[1]);
                }

                reader.Close();
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }

        }
    }
