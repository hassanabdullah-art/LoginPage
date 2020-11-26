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
    public partial class Quiz : Form
    {
        int i,score = 0;
        public static int totalquestions;
        string correctAnswer;
        string topicid;
        public int settime;
        public int correct;
        public int incorrect;
        public int min;
        public int sec = 0;
        public string stname;
        //System.Timers.Timer timer;
        public Quiz(string Topic)
        {
            InitializeComponent();
            topicid = Topic;
            timer.Enabled = true;
            timer.Start();
            option1.Checked = false;
            option2.Checked = false;
            option3.Checked = false;
            option4.Checked = false;
            totalquestions = Convert.ToInt32(rc.scalarReturn("Select count(questionno) from questions where q_fk_exam = " + topicid));
            min = Convert.ToInt32(rc.scalarReturn("Select time from set_quiz where topic_id_fk = " + topicid)) - 1;
            studentname.Text = studentLogin.studentName;
            stname = studentname.Text;
        }
        returnclass rc = new returnclass();

        private void Quiz_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            //timer = new System.Timers.Timer();
            //timer.Elapsed += OnTimeEvent();
            i = Convert.ToInt32(rc.scalarReturn("Select min(questionno) from questions where q_fk_exam = "+ topicid));
            question.Text = rc.scalarReturn("Select question from questions where questionno=" + i + " and q_fk_exam = " + topicid);
            option1.Text = rc.scalarReturn("Select optionA from questions where questionno=" + i + " and q_fk_exam = " + topicid);
            option2.Text = rc.scalarReturn("Select optionB from questions where questionno=" + i + " and q_fk_exam = " + topicid);
            option3.Text = rc.scalarReturn("Select optionC from questions where questionno=" + i + " and q_fk_exam = " + topicid);
            option4.Text = rc.scalarReturn("Select optionD from questions where questionno=" + i + " and q_fk_exam = " + topicid);
            correctAnswer = rc.scalarReturn("Select correctAnswer from questions where questionno=" + i + " and q_fk_exam = " + topicid);
        }
        string s,selectedvalue;

        private void back_Click(object sender, EventArgs e)
        {
            intro_to_computer_software_and_hardware intro_To_Computer_Software_And_Hardware = new intro_to_computer_software_and_hardware(stname);
            this.Hide();
            intro_To_Computer_Software_And_Hardware.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //sec = 60;
            minute.Text = min.ToString();
            sec--;
            second.Text = sec.ToString();
            if(sec == 0)
            {
                min--;
                minute.Text = min.ToString();
            }
            if (sec <= 0)
            {
                sec = 60;
                sec--;
                second.Text = sec.ToString();
            }
            if (min < 0)
            {
                sec = 00;
                min = 00;
                timer.Stop();
                minute.Text = min.ToString();
                second.Text = sec.ToString();
            }

            if(sec == 00 && min == 00)
            {
                timer.Stop();
                option1.Enabled = false;
                option2.Enabled = false;
                option3.Enabled = false;
                option4.Enabled = false;
                MessageBox.Show("Time's up\n");
                next.Text = "Finish";
            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            if(option1.Checked == true)
            {
                selectedvalue = option1.Text;
            }
            else if(option2.Checked == true)
            {
                selectedvalue = option2.Text;
            }
            else if (option3.Checked == true)
            {
                selectedvalue = option3.Text;
            }
            else if (option4.Checked == true)
            {
                selectedvalue = option4.Text;
            }
            /*else
            {
                MessageBox.Show("Please select on option");
            }*/

            if ((selectedvalue.Equals(correctAnswer)) && (option1.Checked == true || option2.Checked == true || option3.Checked == true || option4.Checked == true))
            {
                score++;
                correct++;
            }
            else
            {
                incorrect++;
            }

            if(option1.Checked == false && option2.Checked == false && option3.Checked == false && option4.Checked == false)
            {
                score = score;
            }
            option1.Enabled = true;
            option2.Enabled = true;
            option3.Enabled = true;
            option4.Enabled = true;
            option1.Checked = false;
            option2.Checked = false;
            option3.Checked = false;
            option4.Checked = false;
            timer.Enabled = true;
            timer.Start();

            s = rc.scalarReturn("Select min(questionno) from questions where questionno>" + i + " and q_fk_exam = " + topicid);
            if (s.Equals(""))
            {
                MessageBox.Show("Quiz Over");
                timer.Stop();
               //next.Enabled = false;
                next.Text = "Finish";
            }
            else
            {

                i = Convert.ToInt32(s);
                question.Text = rc.scalarReturn("Select question from questions where questionno=" + i + " and q_fk_exam = "+ topicid);
                option1.Text = rc.scalarReturn("Select optionA from questions where questionno=" + i + " and q_fk_exam = " + topicid);
                option2.Text = rc.scalarReturn("Select optionB from questions where questionno=" + i + " and q_fk_exam = " + topicid);
                option3.Text = rc.scalarReturn("Select optionC from questions where questionno=" + i + " and q_fk_exam = " + topicid);
                option4.Text = rc.scalarReturn("Select optionD from questions where questionno=" + i + " and q_fk_exam = " + topicid);
                correctAnswer = rc.scalarReturn("Select correctAnswer from questions where questionno=" + i + " and q_fk_exam = " + topicid);
            }

            if(next.Text == "Finish")
            {
                this.Close();
                this.Hide();
                Result_Screen resultsScreen = new Result_Screen(intro_to_computer_software_and_hardware.topicname, intro_to_computer_software_and_hardware.stName, totalquestions, correct, incorrect, score);
                resultsScreen.Show();
            }
        }
    }
}
