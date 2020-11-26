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
    public partial class Evaluation_Exercise_1 : Form
    {
        //int generated;
        string topicname = "Introduction to Computer Hardware and Software";

        int Correct;
        int incorrect;
        //int NotAttempted;
        string correctAnswer;
       // string hint;
        int questionNumber = 1;
        public static int score = 0;
        //int percentage;
        int totalQuestions;
        string studentName;
        Random Rno = new Random();

        public Evaluation_Exercise_1(string UserName)
        {
            InitializeComponent();
            Rno = new Random();

            askQuestion(questionNumber);

            username.Text = UserName;
            studentName = username.Text;

            totalQuestions = 20;
        }
        string  selectedvalue;
        RadioButton selctedbutton;
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            //try
            //{
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                if (radioButton1.Checked == true)
                {
                    selectedvalue = radioButton1.Text;
                    selctedbutton = radioButton1;
                }
                else if (radioButton2.Checked == true)
                {
                    selectedvalue = radioButton2.Text;
                    selctedbutton = radioButton2;
                }
                else if (radioButton3.Checked == true)
                {
                    selectedvalue = radioButton3.Text;
                    selctedbutton = radioButton3;
                }
                else if (radioButton4.Checked == true)
                {
                    selectedvalue = radioButton4.Text;
                    selctedbutton = radioButton4;
                }

                if (correctAnswer == radioButton1.Text)
                {
                    ////radioButton1.Checked = true;
                    //radioButton1.Enabled = false;
                    radioButton1.ForeColor = Color.Green;
                }
                else if (correctAnswer == radioButton2.Text)
                {
                    //radioButton2.Checked = true;
                    //radioButton2.Enabled = false;
                    radioButton2.ForeColor = Color.Green;
                }
                else if (correctAnswer == radioButton3.Text)
                {
                    //radioButton3.Checked = true;
                    //radioButton3.Enabled = false;
                    radioButton3.ForeColor = Color.Green;
                }
                else if (correctAnswer == radioButton4.Text)
                {
                    //radioButton4.Checked = true;
                    //radioButton4.Enabled = false;
                    radioButton4.ForeColor = Color.Green;
                }
                if (selctedbutton == radioButton1 && correctAnswer != radioButton1.Text)
                {
                    radioButton1.Checked = true;
                    radioButton1.ForeColor = Color.Red;
                }
                else if (selctedbutton == radioButton2 && correctAnswer != radioButton2.Text)
                {
                    radioButton2.Checked = true;
                    radioButton2.ForeColor = Color.Red;
                }
                else if (selctedbutton == radioButton3 && correctAnswer != radioButton3.Text)
                {
                    radioButton3.Checked = true;
                    radioButton3.ForeColor = Color.Red;
                }
                else if (selctedbutton == radioButton4 && correctAnswer != radioButton4.Text)
                {
                    radioButton4.Checked = true;
                    radioButton4.ForeColor = Color.Red;
                }


                if (selectedvalue == correctAnswer)
                {
                    score++;
                    //lblscore.Text = score.ToString();
                    Correct++;
                    //lblqno.Text = correctAnswer;

                }
                else
                {
                    incorrect++;
                }

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                radioButton3.ForeColor = Color.Black;
                radioButton4.ForeColor = Color.Black;
                //lblhint.Text = "";

                if (questionNumber == totalQuestions - 1)
                {
                    Nextbtn.Text = "Finish";
                }
                if (questionNumber == totalQuestions)
                {
                    this.Close();
                    //Show results screen
                    Result_Screen resultsScreen = new Result_Screen(topicname, studentName,totalQuestions, Correct, incorrect, score);
                    resultsScreen.Show();
                    score = 0;
                    //lblscore.Text = score.ToString();
                }

                questionNumber++;
                askQuestion(questionNumber);
            }
            else
            {
                //Error err = new Error();
                //err.Show();
                //previousQuestion(questionNumber, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);
                MessageBox.Show("Please select an Option");

            }

        }


        String selectedText;

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selectedText = ((RadioButton)sender).Text;

        }

        private void Exercise_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //intro_to_computer_software_and_hardware intro_To_Computer_Software_And_ = new intro_to_computer_software_and_hardware();
            //intro_To_Computer_Software_And_.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            intro_to_computer_software_and_hardware intro_To_Computer_Software_And_ = new intro_to_computer_software_and_hardware(studentName);
            this.Hide();
            intro_To_Computer_Software_And_.Show();
        }

        private void Evaluation_Exercise_1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    lblQuestionno.Text = "Question no 1";
                    //pictureBox1.Image = Properties.Resources.questions;
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "What is an electronic device that manipulates Information and Data?";

                            radioButton1.Text = "Computer";
                            radioButton2.Text = "Typewriter";
                            radioButton3.Text = "Mouse";
                            radioButton4.Text = "Printer";

                            correctAnswer = radioButton1.Text;

                            break;
                        case 2:
                            //pictureBox1.Image = Properties.Resources.questions;
                            lblQuestion.Text = "What is a disadvantage of using computers?";

                            radioButton1.Text = "Computers can do a work faster";
                            radioButton2.Text = "Computers helps us to communicate faster";
                            radioButton3.Text = "Computer do the job easier";
                            radioButton4.Text = "Computers replace humans peaple will not have jobs to do";

                            correctAnswer = radioButton4.Text;

                            break;
                        case 3:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "Device that shows the Output are called";

                            radioButton1.Text = "Storage Device";
                            radioButton2.Text = "Input Device";
                            radioButton3.Text = "Output Device ";
                            radioButton4.Text = "Speaker";

                            correctAnswer = radioButton3.Text;

                            break;
                        case 4:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "Computer Accepts Data and instructions from -------------- Device";

                            radioButton1.Text = "Storage Device";
                            radioButton2.Text = "Input Device";
                            radioButton3.Text = "Output Device ";
                            radioButton4.Text = "Speaker";   

                    correctAnswer = radioButton2.Text;

                            break;

                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "This arrow is called";

                            radioButton1.Text = "Cursor";
                            radioButton2.Text = "Mouse Pointer";
                            radioButton3.Text = "Scroll";
                            radioButton4.Text = "Roller";

                            correctAnswer = radioButton2.Text;

                            break;

                        case 6:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "What is the name of this Output Device";

                            radioButton1.Text = "Monitor";
                            radioButton2.Text = "Keyboard";
                            radioButton3.Text = "Mouse";
                            radioButton4.Text = "CPU";

                            correctAnswer = radioButton1.Text;

                            break;

                        case 7:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Logical Decision is some decision which based on some -----------------.";

                            radioButton1.Text = "arguments";
                            radioButton2.Text = "rule";
                            radioButton3.Text = "reason";
                            radioButton4.Text = "reason or rule";

                            correctAnswer = radioButton4.Text;

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 8:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "In which Operation Computer perform some actions on the data according to the instructions";

                            radioButton1.Text = "Input";
                            radioButton2.Text = "Output";
                            radioButton3.Text = "Processing";
                            radioButton4.Text = "Storage";

                            correctAnswer = radioButton3.Text;

                            break;
                     case 9:
                    //lblQuestionno.Text = "Question no 2";
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "------------ enables us to select comments quickly and perform tasks in a computer";

                            radioButton1.Text = "Mouse ";
                            radioButton2.Text = "Keybord";
                            radioButton3.Text = "Monitor";
                            radioButton4.Text = "CPU";

                            correctAnswer = radioButton1.Text;

                            break;
                        case 10:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "It permanently holds the Data";

                            radioButton1.Text = "Input Device";
                            radioButton2.Text = "Output Device";
                            radioButton3.Text = "Memory";
                            radioButton4.Text = "Storage Device";

                            correctAnswer = radioButton4.Text;

                            break;
                        case 11:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "It holds instructions and data that a computer's processor can access.";

                            radioButton1.Text = "Storage";
                            radioButton2.Text = "Memory";
                            radioButton3.Text = "Processor";
                            radioButton4.Text = "ROM";

                            correctAnswer = radioButton2.Text;

                            break;
                        case 12:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "MS Word is a -----------";

                            radioButton1.Text = "Software";
                            radioButton2.Text = "Hardware";
                            radioButton3.Text = "System";
                            radioButton4.Text = "Processor";

                            correctAnswer = radioButton1.Text;

                            break;

                        case 13:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Which one of the following is a Search Engine?";

                            radioButton1.Text = "Mozila Fire Fox";
                            radioButton2.Text = "Bing";
                            radioButton3.Text = "Google Chrome";
                            radioButton4.Text = "Internet Explorer";

                            correctAnswer = radioButton3.Text;

                            // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 14:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Computer also has a memory.Whenever we need any information from computer,we can get it from it's memory,which is a --------- memory.";

                            radioButton1.Text = "RAM";
                            radioButton2.Text = "ROM";
                            radioButton3.Text = "Drive";
                            radioButton4.Text = "USB";

                            correctAnswer = radioButton1.Text;

                            break;
                        case 15:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Name the Computer Hardware shown";

                            radioButton1.Text = "Keyboard ";
                            radioButton2.Text = "Monitor ";
                            radioButton3.Text = "Mouse ";
                            radioButton4.Text = "CPU ";

                            correctAnswer = radioButton4.Text;

                            break;
                        case 16:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "The CPU is called the ------------- of the Computer.";

                            radioButton1.Text = "arm";
                            radioButton2.Text = "mother";
                            radioButton3.Text = "brains";
                            radioButton4.Text = "legs";

                            correctAnswer = radioButton3.Text;

                            break;
                case 17:

                    //lblQuestionno.Text = "Question no 3";
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "---------------- is also known as brain of Computer";

                            radioButton1.Text = "Memory";
                            radioButton2.Text = "CPU";
                            radioButton3.Text = "Processor";
                            radioButton4.Text = "Mouse";

                            correctAnswer = radioButton3.Text;

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 18:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "A ----------- is a device that is used to save our work in a computer.";

                            radioButton1.Text = "Storage Device";
                            radioButton2.Text = "Input Device";
                            radioButton3.Text = "Output Device";
                            radioButton4.Text = "CPU";

                            correctAnswer = radioButton1.Text;

                            break;
                        case 19:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "USB (flash Drive) a small pen shaped device used for ---------------- data.";

                            radioButton1.Text = "CD";
                            radioButton2.Text = "transfering";
                            radioButton3.Text = "storing";
                            radioButton4.Text = "storing and transfering";

                            correctAnswer = radioButton4.Text;

                            break;
                        case 20:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "This is an image of what type of hardware?";

                            radioButton1.Text = "Scanner";
                            radioButton2.Text = "Printer";
                            radioButton3.Text = "Mouse";
                            radioButton4.Text = "Keyboard";

                            correctAnswer = radioButton3.Text;

                            break;

            }

        }

    }
}
