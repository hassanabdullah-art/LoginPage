namespace LoginPage
{
    partial class Quiz
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
            this.components = new System.ComponentModel.Container();
            this.question = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(158, 110);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(86, 31);
            this.question.TabIndex = 0;
            this.question.Text = "label1";
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(162, 219);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(14, 13);
            this.option1.TabIndex = 1;
            this.option1.TabStop = true;
            this.option1.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(498, 219);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(14, 13);
            this.option2.TabIndex = 2;
            this.option2.TabStop = true;
            this.option2.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(162, 323);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(14, 13);
            this.option3.TabIndex = 3;
            this.option3.TabStop = true;
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4.Location = new System.Drawing.Point(498, 323);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(14, 13);
            this.option4.TabIndex = 4;
            this.option4.TabStop = true;
            this.option4.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(666, 385);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 5;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(663, 69);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(22, 16);
            this.second.TabIndex = 7;
            this.second.Text = "00";
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Location = new System.Drawing.Point(621, 69);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(22, 16);
            this.minute.TabIndex = 8;
            this.minute.Text = "00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = ":";
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.Location = new System.Drawing.Point(13, 13);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(45, 16);
            this.studentname.TabIndex = 10;
            this.studentname.Text = "label1";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(713, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 11;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.second);
            this.Controls.Add(this.next);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.question);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option4;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label minute;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.Button back;
    }
}