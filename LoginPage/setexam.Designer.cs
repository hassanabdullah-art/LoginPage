namespace LoginPage
{
    partial class setexam
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
            this.SpecificRegisteredStudent = new System.Windows.Forms.DataGridView();
            this.addexam = new System.Windows.Forms.DataGridView();
            this.exam_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stid = new System.Windows.Forms.TextBox();
            this.examnamecombobox = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.teachername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timecomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificRegisteredStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addexam)).BeginInit();
            this.SuspendLayout();
            // 
            // SpecificRegisteredStudent
            // 
            this.SpecificRegisteredStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecificRegisteredStudent.Location = new System.Drawing.Point(12, 275);
            this.SpecificRegisteredStudent.Name = "SpecificRegisteredStudent";
            this.SpecificRegisteredStudent.Size = new System.Drawing.Size(809, 296);
            this.SpecificRegisteredStudent.TabIndex = 0;
            // 
            // addexam
            // 
            this.addexam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addexam.Location = new System.Drawing.Point(413, 85);
            this.addexam.Name = "addexam";
            this.addexam.Size = new System.Drawing.Size(408, 173);
            this.addexam.TabIndex = 1;
            // 
            // exam_name
            // 
            this.exam_name.AutoSize = true;
            this.exam_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam_name.Location = new System.Drawing.Point(57, 138);
            this.exam_name.Name = "exam_name";
            this.exam_name.Size = new System.Drawing.Size(83, 16);
            this.exam_name.TabIndex = 2;
            this.exam_name.Text = "Topic Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID";
            // 
            // stid
            // 
            this.stid.Location = new System.Drawing.Point(145, 183);
            this.stid.Name = "stid";
            this.stid.Size = new System.Drawing.Size(121, 20);
            this.stid.TabIndex = 4;
            // 
            // examnamecombobox
            // 
            this.examnamecombobox.FormattingEnabled = true;
            this.examnamecombobox.Location = new System.Drawing.Point(145, 138);
            this.examnamecombobox.Name = "examnamecombobox";
            this.examnamecombobox.Size = new System.Drawing.Size(121, 21);
            this.examnamecombobox.TabIndex = 5;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(191, 235);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(746, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(278, 235);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(90, 23);
            this.send.TabIndex = 8;
            this.send.Text = "Send to All";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // teachername
            // 
            this.teachername.AutoSize = true;
            this.teachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachername.Location = new System.Drawing.Point(13, 13);
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(45, 16);
            this.teachername.TabIndex = 9;
            this.teachername.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Set Time";
            // 
            // timecomboBox
            // 
            this.timecomboBox.FormattingEnabled = true;
            this.timecomboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.timecomboBox.Location = new System.Drawing.Point(145, 101);
            this.timecomboBox.Name = "timecomboBox";
            this.timecomboBox.Size = new System.Drawing.Size(121, 21);
            this.timecomboBox.TabIndex = 11;
            // 
            // setexam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 572);
            this.Controls.Add(this.timecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teachername);
            this.Controls.Add(this.send);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.examnamecombobox);
            this.Controls.Add(this.stid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exam_name);
            this.Controls.Add(this.addexam);
            this.Controls.Add(this.SpecificRegisteredStudent);
            this.Name = "setexam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "setexam";
            this.Load += new System.EventHandler(this.setexam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpecificRegisteredStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addexam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SpecificRegisteredStudent;
        private System.Windows.Forms.DataGridView addexam;
        private System.Windows.Forms.Label exam_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stid;
        private System.Windows.Forms.ComboBox examnamecombobox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label teachername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timecomboBox;
    }
}