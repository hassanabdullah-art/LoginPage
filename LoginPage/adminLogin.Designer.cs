namespace LoginPage
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backpicturebox = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(582, 348);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(250, 45);
            this.password.TabIndex = 2;
            this.password.Text = "●●●●●●●●●";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            // 
            // userName
            // 
            this.userName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.userName.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Gray;
            this.userName.Location = new System.Drawing.Point(582, 277);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(250, 45);
            this.userName.TabIndex = 1;
            this.userName.Text = "Username";
            this.userName.Enter += new System.EventHandler(this.userName_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Super Boom", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(691, 114);
            this.label3.TabIndex = 8;
            this.label3.Text = "Admin Portal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(653, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Forget Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(856, 408);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 33);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tour";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-6, 425);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.backpicturebox);
            this.panel2.Location = new System.Drawing.Point(907, -62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 154);
            this.panel2.TabIndex = 49;
            // 
            // backpicturebox
            // 
            this.backpicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backpicturebox.BackColor = System.Drawing.Color.Transparent;
            this.backpicturebox.Image = ((System.Drawing.Image)(resources.GetObject("backpicturebox.Image")));
            this.backpicturebox.Location = new System.Drawing.Point(47, 64);
            this.backpicturebox.Name = "backpicturebox";
            this.backpicturebox.Size = new System.Drawing.Size(37, 38);
            this.backpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backpicturebox.TabIndex = 0;
            this.backpicturebox.TabStop = false;
            this.backpicturebox.Click += new System.EventHandler(this.backpicturebox_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Image = ((System.Drawing.Image)(resources.GetObject("login.Image")));
            this.login.Location = new System.Drawing.Point(582, 408);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 78);
            this.login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login.TabIndex = 50;
            this.login.TabStop = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.login_Click);
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.MaximumSize = new System.Drawing.Size(1680, 1050);
            this.MinimumSize = new System.Drawing.Size(400, 39);
            this.Name = "adminLogin";
            this.Load += new System.EventHandler(this.adminLogin_Load);
            this.Click += new System.EventHandler(this.login_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox backpicturebox;
        private System.Windows.Forms.PictureBox login;
        private System.Windows.Forms.Label label2;
    }
}