namespace LoginPage
{
    partial class Evaluation_Exercise_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(178, 224);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(541, 226);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(178, 304);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(101, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(541, 304);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(451, 78);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(75, 23);
            this.Nextbtn.TabIndex = 4;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(175, 85);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(64, 16);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question:";
            // 
            // lblQuestionno
            // 
            this.lblQuestionno.AutoSize = true;
            this.lblQuestionno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionno.Location = new System.Drawing.Point(175, 53);
            this.lblQuestionno.Name = "lblQuestionno";
            this.lblQuestionno.Size = new System.Drawing.Size(64, 16);
            this.lblQuestionno.TabIndex = 6;
            this.lblQuestionno.Text = "Question:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 86);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(36, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 25);
            this.username.TabIndex = 8;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(713, 17);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Evaluation_Exercise_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuestionno);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Evaluation_Exercise_1";
            this.Text = "Evaluation_Exercise_1";
            this.Load += new System.EventHandler(this.Evaluation_Exercise_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button back;
    }
}