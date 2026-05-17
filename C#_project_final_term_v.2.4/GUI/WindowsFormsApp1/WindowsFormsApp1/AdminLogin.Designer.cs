namespace WindowsFormsApp1
{
    partial class AdminLogin
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
            this.adminLabel = new System.Windows.Forms.Label();
            this.aiubIdLabel = new System.Windows.Forms.Label();
            this.aiubIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminLabel
            // 
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.adminLabel.Location = new System.Drawing.Point(277, 70);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(308, 61);
            this.adminLabel.TabIndex = 0;
            this.adminLabel.Text = "Admin Login";
            // 
            // aiubIdLabel
            // 
            this.aiubIdLabel.AutoSize = true;
            this.aiubIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubIdLabel.Location = new System.Drawing.Point(164, 193);
            this.aiubIdLabel.Name = "aiubIdLabel";
            this.aiubIdLabel.Size = new System.Drawing.Size(82, 25);
            this.aiubIdLabel.TabIndex = 1;
            this.aiubIdLabel.Text = "AIUB ID";
            // 
            // aiubIdTextBox
            // 
            this.aiubIdTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.aiubIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiubIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.aiubIdTextBox.Location = new System.Drawing.Point(268, 189);
            this.aiubIdTextBox.Name = "aiubIdTextBox";
            this.aiubIdTextBox.Size = new System.Drawing.Size(301, 32);
            this.aiubIdTextBox.TabIndex = 2;
            this.aiubIdTextBox.TextChanged += new System.EventHandler(this.aiubIdTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(116, 281);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(130, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(268, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 32);
            this.textBox1.TabIndex = 4;
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminLoginButton.Location = new System.Drawing.Point(268, 368);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(260, 64);
            this.adminLoginButton.TabIndex = 5;
            this.adminLoginButton.Text = "Admin Login";
            this.adminLoginButton.UseVisualStyleBackColor = false;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(665, 475);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 37);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.aiubIdTextBox);
            this.Controls.Add(this.aiubIdLabel);
            this.Controls.Add(this.adminLabel);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label aiubIdLabel;
        private System.Windows.Forms.TextBox aiubIdTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.Button backButton;
    }
}