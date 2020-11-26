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
    public partial class PracticeExercise : Form
    {
        string stName;
        string studentid;
        int stid;
        string stname;
        string studentName;

        // quiz game variables

        int generated;
        int generated1;
        int generated2;
        int generated3;
        int generated4;
        int generated5;
        int generated6;
        int generated7;

        string topicname = "Introduction to Computer Hardware and Software";


        int Correct;
        int incorrect;
        //int NotAttempted;
        string correctAnswer;
        string hint;
        int questionNumber = 1;
        public static int score = 0;
        //int percentage;
        int totalQuestions;
        Random Rno = new Random();
        string studentname;
       // int ID;
        public PracticeExercise(string UserName)
        {
            InitializeComponent();
            stid = studentLogin.StudentID;
            stname = studentLogin.studentName;
            stuname.Text = UserName;
            stName = stuname.Text;




            Rno = new Random();

            askQuestion(questionNumber);

            //username.Text = UserName;
             //studentname = username.Text;

            //ID = studentid;

            totalQuestions = 10;
        }
        string s, selectedvalue;
        RadioButton selctedbutton;
       

  
        String selectedText;

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selectedText = ((RadioButton)sender).Text;

        }

       

        public void previousQuestion(int qnum, string question, string rb1, string rb2, string rb3, string rb4, string answer, string hint)
        {
            questionNumber = qnum;
            lblQuestion.Text = question;

            radioButton1.Text = rb1;
            radioButton2.Text = rb2;
            radioButton3.Text = rb3;
            radioButton4.Text = rb4;

            correctAnswer = answer;

            //lblhint.Text = hint;
        }

        private void Exercise_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            intro_to_computer_software_and_hardware intro_To_Computer_Software_And_ = new intro_to_computer_software_and_hardware(studentname);
            this.Hide();
            intro_To_Computer_Software_And_.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        AccountType accountType = new AccountType();

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountType.Show();
        }

        
      

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Please select an option first");
            }

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


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
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
                int x = 1;

                if (correctAnswer == radioButton1.Text)
                {
                    ////radioButton1.Checked = true;
                    //radioButton1.Enabled = false;
                    radioButton1.ForeColor = Color.Green;
                    x = 1;
                }
                else if (correctAnswer == radioButton2.Text)
                {
                    //radioButton2.Checked = true;
                    //radioButton2.Enabled = false;
                    radioButton2.ForeColor = Color.Green;
                    x = 1;
                }
                else if (correctAnswer == radioButton3.Text)
                {
                    //radioButton3.Checked = true;
                    //radioButton3.Enabled = false;
                    radioButton3.ForeColor = Color.Green;
                    x = 1;
                }
                else if (correctAnswer == radioButton4.Text)
                {
                    //radioButton4.Checked = true;
                    //radioButton4.Enabled = false;
                    radioButton4.ForeColor = Color.Green;
                    x = 1;
                }
                int y = 2;
                if (selctedbutton == radioButton1 && correctAnswer != radioButton1.Text)
                {
                    radioButton1.Checked = true;
                    radioButton1.ForeColor = Color.Red;
                    y = 2;
                }
                else if (selctedbutton == radioButton2 && correctAnswer != radioButton2.Text)
                {
                    radioButton2.Checked = true;
                    radioButton2.ForeColor = Color.Red;
                    y = 2;
                }
                else if (selctedbutton == radioButton3 && correctAnswer != radioButton3.Text)
                {
                    radioButton3.Checked = true;
                    radioButton3.ForeColor = Color.Red;
                    y = 2;
                }
                else if (selctedbutton == radioButton4 && correctAnswer != radioButton4.Text)
                {
                    radioButton4.Checked = true;
                    radioButton4.ForeColor = Color.Red;
                    y = 2;
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
                    pictureBox4.Text = "Finish";
                }
                if (questionNumber == totalQuestions)
                {
                    this.Close();
                    //Show results screen
                    intro_to_computer_software_and_hardware topic1 = new intro_to_computer_software_and_hardware(studentname);
                    this.Hide();
                    topic1.Show();
                    //Result_Screen resultsScreen = new Result_Screen(topicname, studentname, totalQuestions, Correct, incorrect, score);
                    //resultsScreen.Show();
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

                //NotAttempted++;
            }
            //}catch(Exception ex)
            //{
            // Console.Write("Please Choose an Option");
            //}


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show(hint, "Hint", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (radioButton1.Checked == true || !radioButton2.Checked || !radioButton3.Checked || !radioButton4.Checked)
            {
                MessageBox.Show(hint, "Hint", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    lblQuestionno.Text = "Question no 1";
                    //pictureBox1.Image = Properties.Resources.questions;
                    generated = Rno.Next(1, 8);
                    switch (generated)
                    {
                        case 1:
                            //pictureBox1.Image = Properties.Resources.questions;
                            lblQuestion.Text = "What are the devices use to store information called?";

                            radioButton1.Text = "Input Devices";
                            radioButton2.Text = "Output Device";
                            radioButton3.Text = "Storage Device";
                            radioButton4.Text = "Communication Device";

                            correctAnswer = radioButton3.Text;

                            hint = "Tha stores the data";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 2:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "Which of the following is not an output device?";

                            radioButton1.Text = "Printer";
                            radioButton2.Text = "Monitior";
                            radioButton3.Text = "Scanner";
                            radioButton4.Text = "Speaker";

                            correctAnswer = radioButton3.Text;

                            hint = "That scans the page";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 3:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "Which of the following is an Input device?";

                            radioButton1.Text = "CPU";
                            radioButton2.Text = "Keyboard";
                            radioButton3.Text = "Mouse";
                            radioButton4.Text = "Monitior";

                            correctAnswer = radioButton2.Text;


                            hint = "That is used for typing";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Which of the following is an output device?";

                            radioButton1.Text = "Keyboard";
                            radioButton2.Text = "Monitior";
                            radioButton3.Text = "Mouse";
                            radioButton4.Text = "System Unit";

                            correctAnswer = radioButton2.Text;

                            hint = "That device is used for viewing our work";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Which of the following controls the hardware?";

                            radioButton1.Text = "Hard disk";
                            radioButton2.Text = "Monitior";
                            radioButton3.Text = "Mouse";
                            radioButton4.Text = "CPU";

                            correctAnswer = radioButton4.Text;

                            hint = "C";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;


                    }



                    break;
                case 2:
                    lblQuestionno.Text = "Question no 2";
                    //pictureBox1.Image = Properties.Resources.questions;

                    generated1 = Rno.Next(1, 5);
                    switch (generated1)
                    {
                        case 1:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "Monitor is an ____________";

                            radioButton1.Text = "Input";
                            radioButton2.Text = "Output";
                            radioButton3.Text = "Hardware";
                            radioButton4.Text = "Software";

                            correctAnswer = radioButton1.Text;

                            hint = "I";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 2:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "Hardware are the ____ parts of a Computer";

                            radioButton1.Text = "Logical";
                            radioButton2.Text = "Physical";
                            radioButton3.Text = "Conceptual";
                            radioButton4.Text = "Technical";

                            correctAnswer = radioButton2.Text;

                            hint = "P";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 3:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "A meaningful data is known as ______:";

                            radioButton1.Text = "Calculation";
                            radioButton2.Text = "Information";
                            radioButton3.Text = "Evaluation";
                            radioButton4.Text = "Situation";

                            correctAnswer = radioButton2.Text;

                            hint = "I";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);


                            break;

                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Computer Word is taken from the word:";

                            radioButton1.Text = "Compute";
                            radioButton2.Text = "Calculation";
                            radioButton3.Text = "Compare";
                            radioButton4.Text = "Component";

                            correctAnswer = radioButton2.Text;

                            hint = "That we perform in our mathematics";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Data is collection of ------------:";

                            radioButton1.Text = "Raw Information";
                            radioButton2.Text = "Facts and Figures";
                            radioButton3.Text = "both";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "RI";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                    }


                    break;
                case 3:

                    lblQuestionno.Text = "Question no 3";
                    //pictureBox1.Image = Properties.Resources.csgo;

                    generated2 = Rno.Next(1, 5);
                    switch (generated2)
                    {
                        case 1:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "Most commonly used input device is:";

                            radioButton1.Text = "Monitor";
                            radioButton2.Text = "Scanner";
                            radioButton3.Text = "Keyboard";
                            radioButton4.Text = "Camera";

                            correctAnswer = radioButton3.Text;

                            hint = "That we use for typing";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 2:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "CPU stands for .............";

                            radioButton1.Text = "Central Population Unit";
                            radioButton2.Text = "Central Processing Unit";
                            radioButton3.Text = "Central Publishing Unit";
                            radioButton4.Text = "Control Processing Unit";

                            correctAnswer = radioButton2.Text;

                            hint = "Pro";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 3:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "One of the following is not a part of Keyboard.";

                            radioButton1.Text = "Numeric Keypad";
                            radioButton2.Text = "Funtion Keys";
                            radioButton3.Text = "Navigation Keys";
                            radioButton4.Text = "Mouse";

                            correctAnswer = radioButton4.Text;

                            hint = "It is an Output Device";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);
                           // ;
                            break;

                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Process is any action that is performed on --- to convert it into information?";

                            radioButton1.Text = "Data";
                            radioButton2.Text = "Process Data";
                            radioButton3.Text = "Information";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "D";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;


                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "The parts of Computer that we can touch are known as?";

                            radioButton1.Text = "Hardware";
                            radioButton2.Text = "Software";
                            radioButton3.Text = "Physical Part";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "is set of instructions";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 7:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Software is set of ----------?";

                            radioButton1.Text = "Instructions";
                            radioButton2.Text = "Programs";
                            radioButton3.Text = "Both";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "I";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 8:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Input device are used to enter ------- into the Computer?";

                            radioButton1.Text = "Data";
                            radioButton2.Text = "Information";
                            radioButton3.Text = "Both";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "D";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;



                    }

                    //case 4 ***********************************************************************************



                    break;

                case 4:

                    lblQuestionno.Text = "Question no 4";
                    //pictureBox1.Image = Properties.Resources.csgo;

                    generated3 = Rno.Next(1, 8);
                    switch (generated3)
                    {
                        case 1:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "------- performs all type of processing on data to produce results:";

                            radioButton1.Text = "Microphone";
                            radioButton2.Text = "Processor";
                            radioButton3.Text = "Keyboard";
                            radioButton4.Text = "None";

                            correctAnswer = radioButton2.Text;

                            hint = "It is in our CPU";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 2:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "Processor is known as ........";

                            radioButton1.Text = "CPU";
                            radioButton2.Text = "Main board";
                            radioButton3.Text = "Keyboard";
                            radioButton4.Text = "Mouse";

                            correctAnswer = radioButton1.Text;

                            hint = "C";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 3:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "Window is a --------";

                            radioButton1.Text = "Operating System";
                            radioButton2.Text = "Utility System";
                            radioButton3.Text = "Financial System";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;


                            hint = "O";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "The First screen that appears when the computer is turned on is known as ------";

                            radioButton1.Text = "Desktop";
                            radioButton2.Text = "Notification Area";
                            radioButton3.Text = "Taskbar";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "The main screen that we see after log-in";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "What are the four main component of computer System ?";

                            radioButton1.Text = "CPU , CD-ROM , Mouse , Keyboard";
                            radioButton2.Text = "Memory , Video Card , Monitior , SPW";
                            radioButton3.Text = "Moderm , Keyboard , Word Processor , Printer";
                            radioButton4.Text = "CPU , Memory , Input Devices , Output Devices";

                            correctAnswer = radioButton4.Text;

                            hint = "That perform some works";

                          //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                    }
                    break;


                // case 5***********************************************************

                case 5:

                    lblQuestionno.Text = "Question no 5";
                    //pictureBox1.Image = Properties.Resources.csgo;

                    generated4 = Rno.Next(1, 5);
                    switch (generated4)
                    {
                        case 1:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "A computer works on the principle of Input-Output";

                            radioButton1.Text = "Shortct";
                            radioButton2.Text = "Process";
                            radioButton3.Text = "Calculation";
                            radioButton4.Text = "Addition";

                            correctAnswer = radioButton2.Text;

                            hint = "Pro";

                         //   previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 2:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "The programs that run on a computer are referred to as ";

                            radioButton1.Text = "hardware";
                            radioButton2.Text = "software";
                            radioButton3.Text = "file ware";
                            radioButton4.Text = "soft firm";

                            correctAnswer = radioButton2.Text;

                            hint = "That we can't touch easily";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);
                            //;
                            break;
                        case 3:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "A computer is device that can perform computations and make --------";

                            radioButton1.Text = "Sequential statements";
                            radioButton2.Text = "Arithmetic statements";
                            radioButton3.Text = "logical statements";
                            radioButton4.Text = "Algebraic statements";

                            correctAnswer = radioButton3.Text;


                            hint = "LS";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;



                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Which of the following input device plays an important role using windows ?";

                            radioButton1.Text = "Printer";
                            radioButton2.Text = "Scanner";
                            radioButton3.Text = "Mouse";
                            radioButton4.Text = "Joystick";

                            correctAnswer = radioButton1.Text;

                            hint = "From which we can take prints";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Which is a default folder that stores all deleted files in windows ?";

                            radioButton1.Text = "My Computer";
                            radioButton2.Text = "Waste Box";
                            radioButton3.Text = "Recycle Bin";
                            radioButton4.Text = "Deleted Box";

                            correctAnswer = radioButton3.Text;

                            hint = "Folder icon look like your house bin";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                    }
                    break;
                // case 6 ************************************

                case 6:

                    lblQuestionno.Text = "Question no 6";
                    //pictureBox1.Image = Properties.Resources.csgo;

                    generated5 = Rno.Next(1, 5);
                    switch (generated5)
                    {
                        case 1:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "--------component is used to stored data that is used by the processor";

                            radioButton1.Text = "Scanner";
                            radioButton2.Text = "CPU";
                            radioButton3.Text = "Memory";
                            radioButton4.Text = "Data Store";

                            correctAnswer = radioButton3.Text;

                            hint = "Every Human also has this";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 2:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "What is hardware";

                            radioButton1.Text = "All the ports and buttons of the computer";
                            radioButton2.Text = "is any part of your desktop";
                            radioButton3.Text = "is any part of computer that has a physical structure";
                            radioButton4.Text = "cabels";

                            correctAnswer = radioButton3.Text;

                            hint = "That we can touch easily";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);
                           // ;
                            break;
                        case 3:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "The CPU is called the -------- of the computer ?";

                            radioButton1.Text = "Mind";
                            radioButton2.Text = "Head";
                            radioButton3.Text = "Brain";
                            radioButton4.Text = "Heart";

                            correctAnswer = radioButton3.Text;


                            hint = "Every human also has this from which they think";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Programs that give the instructions to the computer ?";

                            radioButton1.Text = "Data";
                            radioButton2.Text = "Hardware";
                            radioButton3.Text = "Software";
                            radioButton4.Text = "Mother board";

                            correctAnswer = radioButton3.Text;

                            hint = "Our mobile also has this";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;


                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Which of the following is an Input device  ";

                            radioButton1.Text = "Cemra";
                            radioButton2.Text = "Software";
                            radioButton3.Text = "Monitior";
                            radioButton4.Text = "Keyboard";

                            correctAnswer = radioButton4.Text;

                            hint = "This device is used for typing";

                          //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                    }
                    break;

                //case 7 ***************************************************
                case 7:

                    lblQuestionno.Text = "Question no 7";
                    //pictureBox1.Image = Properties.Resources.csgo;

                    generated6 = Rno.Next(1, 5);
                    switch (generated6)
                    {
                        case 1:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "The component allows user to enter text ,number and other information:";

                            radioButton1.Text = "Monitor";
                            radioButton2.Text = "Mouse";
                            radioButton3.Text = "Keyboard";
                            radioButton4.Text = "CPU";

                            correctAnswer = radioButton3.Text;

                            hint = "That has a Alt,Shift and Ctrl Buttons";

                          //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 2:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "Physical parts of a computer .......  such as the keyboard , mouse and monitior";

                            radioButton1.Text = "Hardware";
                            radioButton2.Text = "Software";
                            radioButton3.Text = "Physical part";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton2.Text;

                            hint = "That we cannot touch easily";

                          //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 3:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "The component of computer visually displays the information generated by the computer.";

                            radioButton1.Text = "Monitior";
                            radioButton2.Text = "Hardware";
                            radioButton3.Text = "Screen";
                            radioButton4.Text = "Mother board";

                            correctAnswer = radioButton1.Text;

                            hint = "That shows us our desired work";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);
                            //;
                            break;
                        case 4:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "What is software -------------";

                            radioButton1.Text = "the operating System";
                            radioButton2.Text = "any set of instructions that tells the hardware what to do";
                            radioButton3.Text = "the monitior and computer case";
                            radioButton4.Text = "Physically soft part";

                            correctAnswer = radioButton2.Text;


                            hint = "Programs that give instructions to the computer";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "An example of the computer's software would be ----";

                            radioButton1.Text = "Keyboard";
                            radioButton2.Text = "MS Word";
                            radioButton3.Text = "Both";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton2.Text;

                            hint = "This is a software in which we can writing notes";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        
                    }

                    break;

                //case 8 ****************************************8


                case 8:

                    lblQuestionno.Text = "Question no 8";
                    //pictureBox1.Image = Properties.Resources.csgo;

                    generated7 = Rno.Next(1, 5);
                    switch (generated7)
                    {

                        case 1:
                            //pictureBox1.Image = Properties.Resources.fortnite;

                            lblQuestion.Text = "Computer is an -------------";

                            radioButton1.Text = "Simple Machine";
                            radioButton2.Text = "Electronic Data";
                            radioButton3.Text = "Electronic Machine";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton3.Text;


                            hint = "EM";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 2:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Process is any action that is performed on ----- to convert it into information?";

                            radioButton1.Text = "Data";
                            radioButton2.Text = "Process Data";
                            radioButton3.Text = "information";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "D";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;


                        case 3:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "The parts of Computer that we can touch are known as?";

                            radioButton1.Text = "Hardware";
                            radioButton2.Text = "Software";
                            radioButton3.Text = "Physical Part";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "is any part of computer that has a physical structure";

                          //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Software is set of ----------?";

                            radioButton1.Text = "Instructions";
                            radioButton2.Text = "Programs";
                            radioButton3.Text = "Both";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "I";

                           // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Input device are used to enter ------- into the Computer?";

                            radioButton1.Text = "Data";
                            radioButton2.Text = "Information";
                            radioButton3.Text = "Both";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "D";

                          //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;



                    }
                    break;




                case 9:

                    lblQuestionno.Text = "Question no 9";
                    //pictureBox1.Image = Properties.Resources.csgo;

                    generated7 = Rno.Next(1, 5);
                    switch (generated7)
                    {

                        case 1:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "Most commonly used input device is:";

                            radioButton1.Text = "Monitor";
                            radioButton2.Text = "Scanner";
                            radioButton3.Text = "Keyboard";
                            radioButton4.Text = "Camera";

                            correctAnswer = radioButton3.Text;

                            hint = "M";

                            // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 2:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Process is any action that is performed on ------ to convert it into information?";

                            radioButton1.Text = "Data";
                            radioButton2.Text = "Process Data";
                            radioButton3.Text = "information";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "D";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;


                        case 3:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "any set of instructions that tells the hardware what to do";

                            radioButton1.Text = "Software";
                            radioButton2.Text = "Operating System";
                            radioButton3.Text = "Advice";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "that we cannot touch easily";

                            //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Computer Accepts  ----- to performs Calculations";

                            radioButton1.Text = "Data";
                            radioButton2.Text = "Information";
                            radioButton3.Text = "Both";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "D";

                            // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 5:
                            //pictureBox1.Image = Properties.Resources.questions;

                            lblQuestion.Text = "What is the information we get from Computer called?";

                            radioButton1.Text = "Input";
                            radioButton2.Text = "Output";
                            radioButton3.Text = "Storage";
                            radioButton4.Text = "Data";

                            correctAnswer = radioButton2.Text;

                            hint = "O";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                    }
                    break;





                case 10:

                    lblQuestionno.Text = "Question no 10";
                    //pictureBox1.Image = Properties.Resources.csgo;

                    generated7 = Rno.Next(1, 5);
                    switch (generated7)
                    {

                        case 1:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Which of the following Key is not present on Keyboard?";

                            radioButton1.Text = "Tab";
                            radioButton2.Text = "Shift";
                            radioButton3.Text = "Alt";
                            radioButton4.Text = "Print";

                            correctAnswer = radioButton4.Text;

                            hint = "P";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                        case 2:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "The small pictorial object that represents a program is known as ----";

                            radioButton1.Text = "Desktop";
                            radioButton2.Text = "Icon";
                            radioButton3.Text = "Taskbar";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton1.Text;

                            hint = "The main screen that we see after log-in";

                            //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;


                        case 3:
                            //pictureBox1.Image = Properties.Resources.csgo;

                            lblQuestion.Text = "The information obtained from the computer after processing is ---";

                            radioButton1.Text = "Result ";
                            radioButton2.Text = "Processed Data";
                            radioButton3.Text = "Output";
                            radioButton4.Text = "All of these";

                            correctAnswer = radioButton4.Text;

                            hint = "A";

                            //previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);
                            //;
                            break;

                        case 4:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "A hand-operated device that allows control of the cursor on a computer screen -----?";

                            radioButton1.Text = "Keyboard";
                            radioButton2.Text = "Mouse";
                            radioButton3.Text = "Scanner";
                            radioButton4.Text = "None of these";

                            correctAnswer = radioButton2.Text;

                            hint = "That we uses for controlling our monitor";

                            // previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;
                        case 5:
                            //pictureBox1.Image = Properties.Resources.gears_of_war;

                            lblQuestion.Text = "Security software is designed to protect computers from an assortment of viruses ?";

                            radioButton1.Text = "True";
                            radioButton2.Text = "False";
                            radioButton3.Text = "50% Right";
                            radioButton4.Text = "50% ";

                            correctAnswer = radioButton1.Text;

                            hint = "What do you Think?";

                            //  previousQuestion(qnum, lblQuestion.Text, radioButton1.Text, radioButton2.Text, radioButton3.Text, radioButton4.Text, correctAnswer, lblhint.Text);

                            break;

                    }
                    break;

            }

        }
    }
}
