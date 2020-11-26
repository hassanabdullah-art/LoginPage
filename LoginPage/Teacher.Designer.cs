﻿namespace LoginPage
{
    partial class Teacher
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
            this.SpacificRegisteredStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutteacher = new System.Windows.Forms.Button();
            this.submitcomment = new System.Windows.Forms.Button();
            this.commentToClass = new System.Windows.Forms.TextBox();
            this.sendcomment = new System.Windows.Forms.Button();
            this.managenotification = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpacificRegisteredStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpacificRegisteredStudent
            // 
            this.SpacificRegisteredStudent.AllowUserToAddRows = false;
            this.SpacificRegisteredStudent.AllowUserToDeleteRows = false;
            this.SpacificRegisteredStudent.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.SpacificRegisteredStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpacificRegisteredStudent.Location = new System.Drawing.Point(12, 108);
            this.SpacificRegisteredStudent.Name = "SpacificRegisteredStudent";
            this.SpacificRegisteredStudent.ReadOnly = true;
            this.SpacificRegisteredStudent.Size = new System.Drawing.Size(328, 200);
            this.SpacificRegisteredStudent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Registered";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(268, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(690, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 200);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(410, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(736, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Comment";
            // 
            // logoutteacher
            // 
            this.logoutteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutteacher.Location = new System.Drawing.Point(778, 12);
            this.logoutteacher.Name = "logoutteacher";
            this.logoutteacher.Size = new System.Drawing.Size(138, 49);
            this.logoutteacher.TabIndex = 3;
            this.logoutteacher.Text = "Logout";
            this.logoutteacher.UseVisualStyleBackColor = true;
            this.logoutteacher.Click += new System.EventHandler(this.logoutteacher_Click);
            // 
            // submitcomment
            // 
            this.submitcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitcomment.Location = new System.Drawing.Point(856, 337);
            this.submitcomment.Name = "submitcomment";
            this.submitcomment.Size = new System.Drawing.Size(138, 49);
            this.submitcomment.TabIndex = 3;
            this.submitcomment.Text = "Submit";
            this.submitcomment.UseVisualStyleBackColor = true;
            // 
            // commentToClass
            // 
            this.commentToClass.Location = new System.Drawing.Point(12, 372);
            this.commentToClass.Multiline = true;
            this.commentToClass.Name = "commentToClass";
            this.commentToClass.Size = new System.Drawing.Size(277, 118);
            this.commentToClass.TabIndex = 2;
            // 
            // sendcomment
            // 
            this.sendcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendcomment.Location = new System.Drawing.Point(372, 441);
            this.sendcomment.Name = "sendcomment";
            this.sendcomment.Size = new System.Drawing.Size(138, 49);
            this.sendcomment.TabIndex = 3;
            this.sendcomment.Text = "Send";
            this.sendcomment.UseVisualStyleBackColor = true;
            this.sendcomment.Click += new System.EventHandler(this.sendcomment_Click);
            // 
            // managenotification
            // 
            this.managenotification.Location = new System.Drawing.Point(372, 372);
            this.managenotification.Name = "managenotification";
            this.managenotification.Size = new System.Drawing.Size(138, 49);
            this.managenotification.TabIndex = 4;
            this.managenotification.Text = "Manage ";
            this.managenotification.UseVisualStyleBackColor = true;
            this.managenotification.Click += new System.EventHandler(this.managenotification_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(836, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.managenotification);
            this.Controls.Add(this.sendcomment);
            this.Controls.Add(this.submitcomment);
            this.Controls.Add(this.logoutteacher);
            this.Controls.Add(this.commentToClass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SpacificRegisteredStudent);
            this.KeyPreview = true;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teacher_FormClosed);
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Teacher_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpacificRegisteredStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SpacificRegisteredStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logoutteacher;
        private System.Windows.Forms.Button submitcomment;
        private System.Windows.Forms.TextBox commentToClass;
        private System.Windows.Forms.Button sendcomment;
        private System.Windows.Forms.Button managenotification;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}