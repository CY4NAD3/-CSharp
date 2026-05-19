namespace WindowsFormsApp1
{
    partial class Group
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
            this.courseLabel = new System.Windows.Forms.Label();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.projectTitleLabel = new System.Windows.Forms.Label();
            this.projectTitleTextBox = new System.Windows.Forms.TextBox();
            this.selectTitle = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(48, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(241, 34);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Create New Group";
            // 
            // courseLabel
            // 
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(53, 102);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(140, 23);
            this.courseLabel.TabIndex = 1;
            this.courseLabel.Text = "Course Name :";
            // 
            // courseTextBox
            // 
            this.courseTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.courseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTextBox.Location = new System.Drawing.Point(57, 137);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(199, 27);
            this.courseTextBox.TabIndex = 2;
            // 
            // projectTitleLabel
            // 
            this.projectTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitleLabel.Location = new System.Drawing.Point(53, 187);
            this.projectTitleLabel.Name = "projectTitleLabel";
            this.projectTitleLabel.Size = new System.Drawing.Size(126, 23);
            this.projectTitleLabel.TabIndex = 3;
            this.projectTitleLabel.Text = "Project Title:";
            // 
            // projectTitleTextBox
            // 
            this.projectTitleTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.projectTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitleTextBox.Location = new System.Drawing.Point(57, 228);
            this.projectTitleTextBox.Name = "projectTitleTextBox";
            this.projectTitleTextBox.Size = new System.Drawing.Size(199, 27);
            this.projectTitleTextBox.TabIndex = 4;
            // 
            // selectTitle
            // 
            this.selectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTitle.Location = new System.Drawing.Point(53, 284);
            this.selectTitle.Name = "selectTitle";
            this.selectTitle.Size = new System.Drawing.Size(199, 23);
            this.selectTitle.TabIndex = 5;
            this.selectTitle.Text = "Select Mates to Add:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(53, 310);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(203, 92);
            this.checkedListBox1.TabIndex = 6;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createButton.Location = new System.Drawing.Point(53, 421);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(203, 50);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "CREATE GROUP";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // groupLabel
            // 
            this.groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel.Location = new System.Drawing.Point(373, 41);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(219, 34);
            this.groupLabel.TabIndex = 8;
            this.groupLabel.Text = "Yours Groups";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(378, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 284);
            this.listBox1.TabIndex = 9;
            // 
            // rateButton
            // 
            this.rateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rateButton.Location = new System.Drawing.Point(447, 421);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(203, 50);
            this.rateButton.TabIndex = 10;
            this.rateButton.Text = "RATE MATES";
            this.rateButton.UseVisualStyleBackColor = false;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(674, 492);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Group
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.rateButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.selectTitle);
            this.Controls.Add(this.projectTitleTextBox);
            this.Controls.Add(this.projectTitleLabel);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group";
            this.Load += new System.EventHandler(this.Group_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Label projectTitleLabel;
        private System.Windows.Forms.TextBox projectTitleTextBox;
        private System.Windows.Forms.Label selectTitle;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button rateButton;
        private System.Windows.Forms.Button BackButton;
    }
}