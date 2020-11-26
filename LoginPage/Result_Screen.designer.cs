namespace LoginPage
{
    partial class Result_Screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcorrect = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblincorrect = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Questions:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(23, 58);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(46, 17);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correct Answer:";
            // 
            // lblcorrect
            // 
            this.lblcorrect.AutoSize = true;
            this.lblcorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorrect.ForeColor = System.Drawing.Color.Green;
            this.lblcorrect.Location = new System.Drawing.Point(148, 58);
            this.lblcorrect.Name = "lblcorrect";
            this.lblcorrect.Size = new System.Drawing.Size(46, 17);
            this.lblcorrect.TabIndex = 3;
            this.lblcorrect.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Incorrect Answer:";
            // 
            // lblincorrect
            // 
            this.lblincorrect.AutoSize = true;
            this.lblincorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincorrect.ForeColor = System.Drawing.Color.Red;
            this.lblincorrect.Location = new System.Drawing.Point(270, 58);
            this.lblincorrect.Name = "lblincorrect";
            this.lblincorrect.Size = new System.Drawing.Size(46, 17);
            this.lblincorrect.TabIndex = 5;
            this.lblincorrect.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(393, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Score:";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(393, 58);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(46, 17);
            this.lblscore.TabIndex = 7;
            this.lblscore.Text = "label8";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(192, 143);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(84, 34);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Result_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 280);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblincorrect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcorrect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label1);
            this.Name = "Result_Screen";
            this.Text = "Result_Screen";
            this.Load += new System.EventHandler(this.Result_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcorrect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblincorrect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Button submit;
    }
}