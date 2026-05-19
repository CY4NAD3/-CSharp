namespace Appointment
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtPatient = new System.Windows.Forms.TextBox();
            txtDoctor = new System.Windows.Forms.TextBox();
            txtTime = new System.Windows.Forms.TextBox();
            txtNotes = new System.Windows.Forms.TextBox();
            txtSearch = new System.Windows.Forms.TextBox();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            cmbStatus = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvAppointments = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();

            SuspendLayout();

            label1.Text = "Patient Name";
            label1.Location = new System.Drawing.Point(30, 30);
            label1.Size = new System.Drawing.Size(110, 23);

            label2.Text = "Doctor Name";
            label2.Location = new System.Drawing.Point(30, 65);
            label2.Size = new System.Drawing.Size(110, 23);

            label3.Text = "Date";
            label3.Location = new System.Drawing.Point(30, 100);
            label3.Size = new System.Drawing.Size(110, 23);

            label4.Text = "Time";
            label4.Location = new System.Drawing.Point(30, 135);
            label4.Size = new System.Drawing.Size(110, 23);

            label5.Text = "Status";
            label5.Location = new System.Drawing.Point(30, 170);
            label5.Size = new System.Drawing.Size(110, 23);

            label6.Text = "Notes";
            label6.Location = new System.Drawing.Point(30, 205);
            label6.Size = new System.Drawing.Size(110, 23);

            label7.Text = "Search:";
            label7.Location = new System.Drawing.Point(30, 245);
            label7.Size = new System.Drawing.Size(55, 23);

            txtPatient.Location = new System.Drawing.Point(150, 27);
            txtPatient.Size = new System.Drawing.Size(200, 23);
            txtPatient.Name = "txtPatient";

            txtDoctor.Location = new System.Drawing.Point(150, 62);
            txtDoctor.Size = new System.Drawing.Size(200, 23);
            txtDoctor.Name = "txtDoctor";

            dtpDate.Location = new System.Drawing.Point(150, 97);
            dtpDate.Size = new System.Drawing.Size(200, 23);
            dtpDate.Name = "dtpDate";
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            txtTime.Location = new System.Drawing.Point(150, 132);
            txtTime.Size = new System.Drawing.Size(200, 23);
            txtTime.Name = "txtTime";
            txtTime.Text = "10:00 AM";

            cmbStatus.Location = new System.Drawing.Point(150, 167);
            cmbStatus.Size = new System.Drawing.Size(200, 23);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Items.AddRange(new object[] { "Scheduled", "Completed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;

            txtNotes.Location = new System.Drawing.Point(150, 202);
            txtNotes.Size = new System.Drawing.Size(200, 23);
            txtNotes.Name = "txtNotes";

            txtSearch.Location = new System.Drawing.Point(90, 242);
            txtSearch.Size = new System.Drawing.Size(180, 23);
            txtSearch.Name = "txtSearch";

            btnSave.Text = "Save";
            btnSave.Location = new System.Drawing.Point(150, 280);
            btnSave.Size = new System.Drawing.Size(85, 30);
            btnSave.Click += new System.EventHandler(this.btnSave_Click);

            btnClear.Text = "Clear";
            btnClear.Location = new System.Drawing.Point(240, 280);
            btnClear.Size = new System.Drawing.Size(85, 30);
            btnClear.Click += new System.EventHandler(this.btnClear_Click);

            btnDelete.Text = "Delete";
            btnDelete.Location = new System.Drawing.Point(330, 280);
            btnDelete.Size = new System.Drawing.Size(85, 30);
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            btnSearch.Text = "Search";
            btnSearch.Location = new System.Drawing.Point(280, 240);
            btnSearch.Size = new System.Drawing.Size(85, 30);
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            dgvAppointments.Location = new System.Drawing.Point(30, 325);
            dgvAppointments.Size = new System.Drawing.Size(700, 220);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            ClientSize = new System.Drawing.Size(780, 580);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtPatient);
            Controls.Add(txtDoctor);
            Controls.Add(dtpDate);
            Controls.Add(txtTime);
            Controls.Add(cmbStatus);
            Controls.Add(txtNotes);
            Controls.Add(txtSearch);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(dgvAppointments);
            Text = "Hospital Appointment";
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}