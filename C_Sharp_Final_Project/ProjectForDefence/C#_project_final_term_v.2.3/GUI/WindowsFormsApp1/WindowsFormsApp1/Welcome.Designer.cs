namespace WindowsFormsApp1
{
    partial class Welcome
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginStudent = new System.Windows.Forms.Button();
            this.loginAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(264, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(279, 69);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PeerSync";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(260, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connect , Collaborate , Succeed ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please Choose your role to continue ";
            // 
            // loginStudent
            // 
            this.loginStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStudent.ForeColor = System.Drawing.SystemColors.Info;
            this.loginStudent.Location = new System.Drawing.Point(264, 285);
            this.loginStudent.Name = "loginStudent";
            this.loginStudent.Size = new System.Drawing.Size(260, 64);
            this.loginStudent.TabIndex = 3;
            this.loginStudent.Text = "Login as Student";
            this.loginStudent.UseVisualStyleBackColor = false;
            this.loginStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginAdmin
            // 
            this.loginAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginAdmin.Location = new System.Drawing.Point(264, 371);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(260, 64);
            this.loginAdmin.TabIndex = 4;
            this.loginAdmin.Text = "Login as Admin";
            this.loginAdmin.UseVisualStyleBackColor = false;
            this.loginAdmin.Click += new System.EventHandler(this.loginAdmin_Click);
            // 
            // Welcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.loginAdmin);
            this.Controls.Add(this.loginStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginStudent;
        private System.Windows.Forms.Button loginAdmin;
    }
}

