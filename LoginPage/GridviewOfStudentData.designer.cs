namespace LoginPage
{
    partial class GridviewOfStudentData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridviewOfStudentData));
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backpictureBox = new System.Windows.Forms.PictureBox();
            this.adminname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.PictureBox();
            this.addstudent = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchcombobox = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backpictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGridView
            // 
            this.studentGridView.AllowUserToAddRows = false;
            this.studentGridView.AllowUserToDeleteRows = false;
            this.studentGridView.AllowUserToResizeColumns = false;
            this.studentGridView.AllowUserToResizeRows = false;
            this.studentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(12, 245);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.Size = new System.Drawing.Size(1079, 254);
            this.studentGridView.TabIndex = 1;
            this.studentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellContentClick);
            this.studentGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellEnter);
            this.studentGridView.DoubleClick += new System.EventHandler(this.studentGridView_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "LogOut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(949, 506);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(-6, 523);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(193, 114);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 20;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Super Boom", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 47);
            this.label3.TabIndex = 24;
            this.label3.Text = "Student Management";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.backpictureBox);
            this.panel1.Location = new System.Drawing.Point(1000, -62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 154);
            this.panel1.TabIndex = 52;
            // 
            // backpictureBox
            // 
            this.backpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backpictureBox.Image")));
            this.backpictureBox.Location = new System.Drawing.Point(47, 64);
            this.backpictureBox.Name = "backpictureBox";
            this.backpictureBox.Size = new System.Drawing.Size(37, 38);
            this.backpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backpictureBox.TabIndex = 49;
            this.backpictureBox.TabStop = false;
            this.backpictureBox.Click += new System.EventHandler(this.backpictureBox_Click);
            // 
            // adminname
            // 
            this.adminname.AutoSize = true;
            this.adminname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(226)))), ((int)(((byte)(233)))));
            this.adminname.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminname.Location = new System.Drawing.Point(174, 181);
            this.adminname.Name = "adminname";
            this.adminname.Size = new System.Drawing.Size(72, 29);
            this.adminname.TabIndex = 49;
            this.adminname.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.adminname);
            this.panel3.Location = new System.Drawing.Point(-113, -136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 398);
            this.panel3.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(378, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 143);
            this.panel2.TabIndex = 54;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(528, 516);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(138, 140);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 55;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // addstudent
            // 
            this.addstudent.BackColor = System.Drawing.Color.Transparent;
            this.addstudent.Image = ((System.Drawing.Image)(resources.GetObject("addstudent.Image")));
            this.addstudent.Location = new System.Drawing.Point(739, 516);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(138, 140);
            this.addstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addstudent.TabIndex = 56;
            this.addstudent.TabStop = false;
            this.addstudent.Click += new System.EventHandler(this.addNewStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Delete";
            this.label4.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add New Student";
            this.label2.Click += new System.EventHandler(this.addNewStudent_Click);
            // 
            // searchcombobox
            // 
            this.searchcombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchcombobox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchcombobox.FormattingEnabled = true;
            this.searchcombobox.Items.AddRange(new object[] {
            "Name",
            "Guardian",
            "Registration No",
            "Email Address",
            "Gender",
            "Age",
            "Teacher",
            "Class",
            "Section"});
            this.searchcombobox.Location = new System.Drawing.Point(705, 208);
            this.searchcombobox.Name = "searchcombobox";
            this.searchcombobox.Size = new System.Drawing.Size(165, 31);
            this.searchcombobox.TabIndex = 57;
            this.searchcombobox.Text = "Search";
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(904, 209);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(142, 30);
            this.search.TabIndex = 58;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // GridviewOfStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 686);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchcombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.addstudent);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logout);
            this.MaximumSize = new System.Drawing.Size(1680, 1050);
            this.MinimumSize = new System.Drawing.Size(400, 39);
            this.Name = "GridviewOfStudentData";
            this.Text = "GridviewOfStudentData";
            this.Load += new System.EventHandler(this.GridviewOfStudentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backpictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backpictureBox;
        private System.Windows.Forms.Label adminname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox addstudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchcombobox;
        private System.Windows.Forms.TextBox search;
    }
}