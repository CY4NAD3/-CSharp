namespace WindowsFormsApp1
{
    partial class HomeFeed
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.passButton = new System.Windows.Forms.Button();
            this.reputationLabel = new System.Windows.Forms.Label();
            this.workStyleLabel = new System.Windows.Forms.Label();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.chatButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.passButton);
            this.panel1.Controls.Add(this.reputationLabel);
            this.panel1.Controls.Add(this.workStyleLabel);
            this.panel1.Controls.Add(this.skillsLabel);
            this.panel1.Controls.Add(this.semesterLabel);
            this.panel1.Controls.Add(this.departmentLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(148, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 358);
            this.panel1.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(286, 293);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(150, 38);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            // 
            // passButton
            // 
            this.passButton.BackColor = System.Drawing.Color.Firebrick;
            this.passButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passButton.Location = new System.Drawing.Point(57, 293);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(150, 38);
            this.passButton.TabIndex = 6;
            this.passButton.Text = "PASS";
            this.passButton.UseVisualStyleBackColor = false;
            this.passButton.Click += new System.EventHandler(this.passButton_Click_1);
            // 
            // reputationLabel
            // 
            this.reputationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reputationLabel.ForeColor = System.Drawing.Color.Crimson;
            this.reputationLabel.Location = new System.Drawing.Point(48, 243);
            this.reputationLabel.Name = "reputationLabel";
            this.reputationLabel.Size = new System.Drawing.Size(420, 23);
            this.reputationLabel.TabIndex = 5;
            this.reputationLabel.Text = "Reputation:";
            // 
            // workStyleLabel
            // 
            this.workStyleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workStyleLabel.Location = new System.Drawing.Point(48, 205);
            this.workStyleLabel.Name = "workStyleLabel";
            this.workStyleLabel.Size = new System.Drawing.Size(408, 23);
            this.workStyleLabel.TabIndex = 4;
            this.workStyleLabel.Text = "Work Style:";
            // 
            // skillsLabel
            // 
            this.skillsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillsLabel.Location = new System.Drawing.Point(48, 164);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(425, 23);
            this.skillsLabel.TabIndex = 3;
            this.skillsLabel.Text = "Skills:";
            // 
            // semesterLabel
            // 
            this.semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterLabel.Location = new System.Drawing.Point(48, 122);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(366, 23);
            this.semesterLabel.TabIndex = 2;
            this.semesterLabel.Text = "Semester:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(48, 83);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(425, 23);
            this.departmentLabel.TabIndex = 1;
            this.departmentLabel.Text = "Department:";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameLabel.Location = new System.Drawing.Point(47, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(298, 45);
            this.nameLabel.TabIndex = 0;
            // 
            // chatButton
            // 
            this.chatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chatButton.Location = new System.Drawing.Point(148, 52);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(140, 30);
            this.chatButton.TabIndex = 1;
            this.chatButton.Text = "CHAT";
            this.chatButton.UseVisualStyleBackColor = false;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click_1);
            // 
            // groupsButton
            // 
            this.groupsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupsButton.Location = new System.Drawing.Point(325, 52);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(140, 30);
            this.groupsButton.TabIndex = 2;
            this.groupsButton.Text = "GROUP";
            this.groupsButton.UseVisualStyleBackColor = false;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.profileButton.Location = new System.Drawing.Point(497, 52);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(140, 30);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "PROFILE";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click_1);
            // 
            // HomeFeed
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.panel1);
            this.Name = "HomeFeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Feed";
            this.Load += new System.EventHandler(this.HomeFeed_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label reputationLabel;
        private System.Windows.Forms.Label workStyleLabel;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button chatButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button profileButton;
    }
}