namespace WindowsFormsApp1
{
    partial class ChangePassword
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
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.oldPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.AutoSize = true;
            this.oldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassLabel.Location = new System.Drawing.Point(196, 124);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(132, 20);
            this.oldPassLabel.TabIndex = 0;
            this.oldPassLabel.Text = "Old Password:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(189, 186);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(139, 20);
            this.newPasswordLabel.TabIndex = 1;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassLabel.Location = new System.Drawing.Point(159, 253);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(169, 20);
            this.confirmPassLabel.TabIndex = 2;
            this.confirmPassLabel.Text = "Confirm Password:";
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.oldPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassTextBox.Location = new System.Drawing.Point(363, 124);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.Size = new System.Drawing.Size(212, 27);
            this.oldPassTextBox.TabIndex = 3;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.newPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTextBox.Location = new System.Drawing.Point(363, 183);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(212, 27);
            this.newPassTextBox.TabIndex = 4;
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.confirmPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassTextBox.Location = new System.Drawing.Point(363, 250);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(212, 27);
            this.confirmPassTextBox.TabIndex = 5;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeButton.Location = new System.Drawing.Point(324, 330);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(139, 51);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(681, 487);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 39);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.oldPassTextBox);
            this.Controls.Add(this.confirmPassLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.oldPassLabel);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPassLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.TextBox confirmPassTextBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button backButton;
    }
}