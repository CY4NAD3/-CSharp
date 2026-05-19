namespace WindowsFormsApp1
{
    partial class RateTeamMate
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
            this.selectLabel = new System.Windows.Forms.Label();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.communicationLabel = new System.Windows.Forms.Label();
            this.reliabilityLabel = new System.Windows.Forms.Label();
            this.punctualitylabel = new System.Windows.Forms.Label();
            this.ContributionnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CommunicationnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.ReliabilitynumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.PunctualitynumericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ContributionnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommunicationnumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReliabilitynumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PunctualitynumericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectLabel
            // 
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(125, 26);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(174, 23);
            this.selectLabel.TabIndex = 0;
            this.selectLabel.Text = "Select Teammate:";
            // 
            // contributionLabel
            // 
            this.contributionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributionLabel.Location = new System.Drawing.Point(126, 236);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(164, 23);
            this.contributionLabel.TabIndex = 2;
            this.contributionLabel.Text = "Contribution(1 - 5):";
            // 
            // communicationLabel
            // 
            this.communicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.communicationLabel.Location = new System.Drawing.Point(101, 279);
            this.communicationLabel.Name = "communicationLabel";
            this.communicationLabel.Size = new System.Drawing.Size(189, 23);
            this.communicationLabel.TabIndex = 3;
            this.communicationLabel.Text = "Communication(1 - 5):";
            // 
            // reliabilityLabel
            // 
            this.reliabilityLabel.AutoSize = true;
            this.reliabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reliabilityLabel.Location = new System.Drawing.Point(150, 323);
            this.reliabilityLabel.Name = "reliabilityLabel";
            this.reliabilityLabel.Size = new System.Drawing.Size(140, 22);
            this.reliabilityLabel.TabIndex = 4;
            this.reliabilityLabel.Text = "Reliability(1 - 5):";
            // 
            // punctualitylabel
            // 
            this.punctualitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctualitylabel.Location = new System.Drawing.Point(139, 371);
            this.punctualitylabel.Name = "punctualitylabel";
            this.punctualitylabel.Size = new System.Drawing.Size(151, 23);
            this.punctualitylabel.TabIndex = 5;
            this.punctualitylabel.Text = "Punctuality(1 - 5):";
            // 
            // ContributionnumericUpDown1
            // 
            this.ContributionnumericUpDown1.BackColor = System.Drawing.SystemColors.Menu;
            this.ContributionnumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContributionnumericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ContributionnumericUpDown1.Location = new System.Drawing.Point(515, 236);
            this.ContributionnumericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ContributionnumericUpDown1.Name = "ContributionnumericUpDown1";
            this.ContributionnumericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.ContributionnumericUpDown1.TabIndex = 6;
            // 
            // CommunicationnumericUpDown2
            // 
            this.CommunicationnumericUpDown2.BackColor = System.Drawing.SystemColors.Menu;
            this.CommunicationnumericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommunicationnumericUpDown2.Location = new System.Drawing.Point(515, 279);
            this.CommunicationnumericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CommunicationnumericUpDown2.Name = "CommunicationnumericUpDown2";
            this.CommunicationnumericUpDown2.Size = new System.Drawing.Size(120, 27);
            this.CommunicationnumericUpDown2.TabIndex = 7;
            this.CommunicationnumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ReliabilitynumericUpDown3
            // 
            this.ReliabilitynumericUpDown3.BackColor = System.Drawing.SystemColors.Menu;
            this.ReliabilitynumericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReliabilitynumericUpDown3.Location = new System.Drawing.Point(515, 323);
            this.ReliabilitynumericUpDown3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ReliabilitynumericUpDown3.Name = "ReliabilitynumericUpDown3";
            this.ReliabilitynumericUpDown3.Size = new System.Drawing.Size(120, 27);
            this.ReliabilitynumericUpDown3.TabIndex = 8;
            // 
            // PunctualitynumericUpDown4
            // 
            this.PunctualitynumericUpDown4.BackColor = System.Drawing.SystemColors.Menu;
            this.PunctualitynumericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunctualitynumericUpDown4.Location = new System.Drawing.Point(515, 371);
            this.PunctualitynumericUpDown4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PunctualitynumericUpDown4.Name = "PunctualitynumericUpDown4";
            this.PunctualitynumericUpDown4.Size = new System.Drawing.Size(120, 27);
            this.PunctualitynumericUpDown4.TabIndex = 9;
            this.PunctualitynumericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.Location = new System.Drawing.Point(290, 423);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(202, 63);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(684, 471);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // RateTeamMate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PunctualitynumericUpDown4);
            this.Controls.Add(this.ReliabilitynumericUpDown3);
            this.Controls.Add(this.CommunicationnumericUpDown2);
            this.Controls.Add(this.ContributionnumericUpDown1);
            this.Controls.Add(this.punctualitylabel);
            this.Controls.Add(this.reliabilityLabel);
            this.Controls.Add(this.communicationLabel);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.selectLabel);
            this.Name = "RateTeamMate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Team Mate";
            ((System.ComponentModel.ISupportInitialize)(this.ContributionnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommunicationnumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReliabilitynumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PunctualitynumericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Label communicationLabel;
        private System.Windows.Forms.Label reliabilityLabel;
        private System.Windows.Forms.Label punctualitylabel;
        private System.Windows.Forms.NumericUpDown ContributionnumericUpDown1;
        private System.Windows.Forms.NumericUpDown CommunicationnumericUpDown2;
        private System.Windows.Forms.NumericUpDown ReliabilitynumericUpDown3;
        private System.Windows.Forms.NumericUpDown PunctualitynumericUpDown4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}