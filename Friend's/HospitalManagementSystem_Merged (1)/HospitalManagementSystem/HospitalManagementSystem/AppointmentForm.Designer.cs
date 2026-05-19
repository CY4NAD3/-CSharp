namespace HospitalManagementSystem
{
    partial class AppointmentForm
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
            lblPatient = new System.Windows.Forms.Label();
            txtPatient = new System.Windows.Forms.TextBox();
            lblDoctor = new System.Windows.Forms.Label();
            txtDoctor = new System.Windows.Forms.TextBox();
            lblDate = new System.Windows.Forms.Label();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            lblTime = new System.Windows.Forms.Label();
            txtTime = new System.Windows.Forms.TextBox();
            lblStatus = new System.Windows.Forms.Label();
            cmbStatus = new System.Windows.Forms.ComboBox();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvAppointments = new System.Windows.Forms.DataGridView();

            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();

            panelHeader.BackColor = System.Drawing.Color.Teal;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Height = 55;

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 10);
            lblTitle.Text = "Appointment Management";

            // Left column
            string[] lbTxts = { "Patient Name:", "Doctor Name:", "Date:", "Time (HH:MM):", "Status:", "Notes:" };
            System.Windows.Forms.Label[] lbs = { lblPatient, lblDoctor, lblDate, lblTime, lblStatus, lblNotes };
            for (int i = 0; i < lbs.Length; i++)
            {
                lbs[i].AutoSize = true;
                lbs[i].Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                lbs[i].Location = new System.Drawing.Point(15, 68 + i * 40);
                lbs[i].Text = lbTxts[i];
            }
            txtPatient.Location = new System.Drawing.Point(165, 65);  txtPatient.Size = new System.Drawing.Size(220, 27); txtPatient.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtDoctor.Location  = new System.Drawing.Point(165, 105); txtDoctor.Size  = new System.Drawing.Size(220, 27); txtDoctor.Font  = new System.Drawing.Font("Segoe UI", 9F);
            dtpDate.Location    = new System.Drawing.Point(165, 143); dtpDate.Size    = new System.Drawing.Size(220, 27); dtpDate.Font    = new System.Drawing.Font("Segoe UI", 9F); dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            txtTime.Location    = new System.Drawing.Point(165, 183); txtTime.Size    = new System.Drawing.Size(220, 27); txtTime.Font    = new System.Drawing.Font("Segoe UI", 9F);
            cmbStatus.Location  = new System.Drawing.Point(165, 223); cmbStatus.Size  = new System.Drawing.Size(220, 27); cmbStatus.Font  = new System.Drawing.Font("Segoe UI", 9F);
            cmbStatus.Items.AddRange(new object[] { "Scheduled", "Completed", "Cancelled" }); cmbStatus.SelectedIndex = 0; cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtNotes.Location   = new System.Drawing.Point(165, 263); txtNotes.Size   = new System.Drawing.Size(220, 27); txtNotes.Font   = new System.Drawing.Font("Segoe UI", 9F);

            // Search row
            lblSearch.AutoSize = true; lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F); lblSearch.Location = new System.Drawing.Point(420, 68); lblSearch.Text = "Search:";
            txtSearch.Location = new System.Drawing.Point(490, 65); txtSearch.Size = new System.Drawing.Size(200, 27); txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Buttons
            btnSave.Text = "Save";     btnSave.Location = new System.Drawing.Point(15, 305);  btnSave.Size = new System.Drawing.Size(80, 32);   btnSave.BackColor = System.Drawing.Color.ForestGreen;  btnSave.ForeColor = System.Drawing.Color.White; btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Text = "Clear";   btnClear.Location = new System.Drawing.Point(105, 305); btnClear.Size = new System.Drawing.Size(80, 32);  btnClear.BackColor = System.Drawing.Color.Gray;         btnClear.ForeColor = System.Drawing.Color.White; btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Text = "Delete"; btnDelete.Location = new System.Drawing.Point(195, 305);btnDelete.Size = new System.Drawing.Size(80, 32); btnDelete.BackColor = System.Drawing.Color.Crimson;     btnDelete.ForeColor = System.Drawing.Color.White; btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Text = "Search"; btnSearch.Location = new System.Drawing.Point(700, 63); btnSearch.Size = new System.Drawing.Size(80, 32); btnSearch.BackColor = System.Drawing.Color.Teal;         btnSearch.ForeColor = System.Drawing.Color.White; btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            foreach (var b in new[] { btnSave, btnClear, btnDelete, btnSearch })
                b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            btnSave.Click   += new System.EventHandler(this.btnSave_Click);
            btnClear.Click  += new System.EventHandler(this.btnClear_Click);
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            dgvAppointments.Location = new System.Drawing.Point(0, 350);
            dgvAppointments.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            dgvAppointments.Size = new System.Drawing.Size(940, 300);
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelHeader);
            foreach (var l in lbs) Controls.Add(l);
            Controls.Add(txtPatient); Controls.Add(txtDoctor); Controls.Add(dtpDate);
            Controls.Add(txtTime); Controls.Add(cmbStatus); Controls.Add(txtNotes);
            Controls.Add(lblSearch); Controls.Add(txtSearch);
            Controls.Add(btnSave); Controls.Add(btnClear); Controls.Add(btnDelete); Controls.Add(btnSearch);
            Controls.Add(dgvAppointments);
            Size = new System.Drawing.Size(940, 670);

            panelHeader.ResumeLayout(false); panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle, lblPatient, lblDoctor, lblDate, lblTime, lblStatus, lblNotes, lblSearch;
        private System.Windows.Forms.TextBox txtPatient, txtDoctor, txtTime, txtNotes, txtSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave, btnSearch, btnClear, btnDelete;
        private System.Windows.Forms.DataGridView dgvAppointments;
    }
}
