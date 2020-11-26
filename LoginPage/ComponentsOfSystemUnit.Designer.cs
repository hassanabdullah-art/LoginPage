namespace LoginPage
{
    partial class ComponentsOfSystemUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentsOfSystemUnit));
            this.studentname = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.Location = new System.Drawing.Point(13, 13);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(45, 16);
            this.studentname.TabIndex = 0;
            this.studentname.Text = "label1";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(713, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(122, 150);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(566, 322);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // ComponentsOfSystemUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.studentname);
            this.Name = "ComponentsOfSystemUnit";
            this.Text = "ComponentsOfSystemUnit";
            this.Load += new System.EventHandler(this.ComponentsOfSystemUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.Button back;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}