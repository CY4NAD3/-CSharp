namespace HospitalManagementSystem
{
    partial class DoctorForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblDoctorID = new System.Windows.Forms.Label();
            txtDoctorID = new System.Windows.Forms.TextBox();
            lblDoctorName = new System.Windows.Forms.Label();
            txtDoctorName = new System.Windows.Forms.TextBox();
            lblGender = new System.Windows.Forms.Label();
            cmbGender = new System.Windows.Forms.ComboBox();
            lblSpec = new System.Windows.Forms.Label();
            txtSpecialization = new System.Windows.Forms.TextBox();
            lblRoom = new System.Windows.Forms.Label();
            txtRoomNo = new System.Windows.Forms.TextBox();
            lblTime = new System.Windows.Forms.Label();
            cmbAvailableTime = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            dgvDoctors = new System.Windows.Forms.DataGridView();

            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = System.Drawing.Color.Maroon;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Height = 55;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 10);
            lblTitle.Text = "Doctor Management";

            // Labels & TextBoxes
            string[] lblTexts = { "Doctor ID:", "Doctor Name:", "Gender:", "Specialization:", "Room No:", "Available Time:" };
            int startY = 70;
            System.Windows.Forms.Label[] lbs = { lblDoctorID, lblDoctorName, lblGender, lblSpec, lblRoom, lblTime };
            for (int i = 0; i < lbs.Length; i++)
            {
                lbs[i].AutoSize = true;
                lbs[i].Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                lbs[i].Location = new System.Drawing.Point(15, startY + i * 40);
                lbs[i].Text = lblTexts[i];
            }

            System.Windows.Forms.Control[] inputs = { txtDoctorID, txtDoctorName, cmbGender, txtSpecialization, txtRoomNo, cmbAvailableTime };
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i].Location = new System.Drawing.Point(155, startY - 3 + i * 40);
                inputs[i].Size = new System.Drawing.Size(230, 27);
                inputs[i].Font = new System.Drawing.Font("Segoe UI", 9F);
            }

            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAvailableTime.Items.AddRange(new object[] { "Morning", "Afternoon", "Evening", "Night" });
            cmbAvailableTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Buttons
            System.Windows.Forms.Button[] btns = { btnSave, btnSearch, btnUpdate, btnDelete, btnClear };
            string[] btnTxts = { "Save", "Search", "Update", "Delete", "Clear" };
            System.Drawing.Color[] btnColors = {
                System.Drawing.Color.ForestGreen,
                System.Drawing.Color.DodgerBlue,
                System.Drawing.Color.DarkOrange,
                System.Drawing.Color.Crimson,
                System.Drawing.Color.Gray
            };
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].Text = btnTxts[i];
                btns[i].Location = new System.Drawing.Point(15 + i * 78, 318);
                btns[i].Size = new System.Drawing.Size(73, 32);
                btns[i].BackColor = btnColors[i];
                btns[i].ForeColor = System.Drawing.Color.White;
                btns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btns[i].Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            }
            btnSave.Click   += new System.EventHandler(this.btnSave_Click);
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            btnClear.Click  += new System.EventHandler(this.btnClear_Click);

            // dgvDoctors
            dgvDoctors.Location = new System.Drawing.Point(0, 365);
            dgvDoctors.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            dgvDoctors.Size = new System.Drawing.Size(900, 300);
            dgvDoctors.ReadOnly = true;
            dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellClick);

            // DoctorForm (UserControl)
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelHeader);
            Controls.Add(lblDoctorID); Controls.Add(txtDoctorID);
            Controls.Add(lblDoctorName); Controls.Add(txtDoctorName);
            Controls.Add(lblGender); Controls.Add(cmbGender);
            Controls.Add(lblSpec); Controls.Add(txtSpecialization);
            Controls.Add(lblRoom); Controls.Add(txtRoomNo);
            Controls.Add(lblTime); Controls.Add(cmbAvailableTime);
            Controls.Add(btnSave); Controls.Add(btnSearch);
            Controls.Add(btnUpdate); Controls.Add(btnDelete); Controls.Add(btnClear);
            Controls.Add(dgvDoctors);
            Size = new System.Drawing.Size(900, 680);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDoctorID, lblDoctorName, lblGender, lblSpec, lblRoom, lblTime;
        private System.Windows.Forms.TextBox txtDoctorID, txtDoctorName, txtSpecialization, txtRoomNo;
        private System.Windows.Forms.ComboBox cmbGender, cmbAvailableTime;
        private System.Windows.Forms.Button btnSave, btnSearch, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.DataGridView dgvDoctors;
    }
}
