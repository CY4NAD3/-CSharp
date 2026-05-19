namespace HospitalManagementSystem
{
    partial class PatientForm
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
            lblPatientID = new System.Windows.Forms.Label();
            txtPatientID = new System.Windows.Forms.TextBox();
            lblPatientName = new System.Windows.Forms.Label();
            txtPatientName = new System.Windows.Forms.TextBox();
            lblAge = new System.Windows.Forms.Label();
            txtAge = new System.Windows.Forms.TextBox();
            lblGender = new System.Windows.Forms.Label();
            txtGender = new System.Windows.Forms.TextBox();
            lblAddress = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            btnInsert = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            dgvPatients = new System.Windows.Forms.DataGridView();

            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
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
            lblTitle.Text = "Patient Management";

            string[] lblTexts = { "Patient ID:", "Patient Name:", "Age:", "Gender:", "Address:" };
            System.Windows.Forms.Label[] lbs = { lblPatientID, lblPatientName, lblAge, lblGender, lblAddress };
            System.Windows.Forms.TextBox[] txts = { txtPatientID, txtPatientName, txtAge, txtGender, txtAddress };
            int sy = 70;
            for (int i = 0; i < lbs.Length; i++)
            {
                lbs[i].AutoSize = true;
                lbs[i].Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                lbs[i].Location = new System.Drawing.Point(15, sy + i * 40);
                lbs[i].Text = lblTexts[i];
                txts[i].Location = new System.Drawing.Point(155, sy - 3 + i * 40);
                txts[i].Size = new System.Drawing.Size(230, 27);
                txts[i].Font = new System.Drawing.Font("Segoe UI", 9F);
            }

            System.Windows.Forms.Button[] btns = { btnInsert, btnUpdate, btnDelete, btnClear };
            string[] btnTxts = { "Insert", "Update", "Delete", "Clear" };
            System.Drawing.Color[] colors = {
                System.Drawing.Color.ForestGreen, System.Drawing.Color.DarkOrange,
                System.Drawing.Color.Crimson, System.Drawing.Color.Gray };
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].Text = btnTxts[i];
                btns[i].Location = new System.Drawing.Point(15 + i * 90, 290);
                btns[i].Size = new System.Drawing.Size(82, 32);
                btns[i].BackColor = colors[i];
                btns[i].ForeColor = System.Drawing.Color.White;
                btns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btns[i].Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            }
            btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            btnClear.Click  += new System.EventHandler(this.btnClear_Click);

            dgvPatients.Location = new System.Drawing.Point(0, 340);
            dgvPatients.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            dgvPatients.Size = new System.Drawing.Size(900, 300);
            dgvPatients.ReadOnly = true;
            dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellClick);

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelHeader);
            foreach (var l in lbs) Controls.Add(l);
            foreach (var t in txts) Controls.Add(t);
            foreach (var b in btns) Controls.Add(b);
            Controls.Add(dgvPatients);
            Size = new System.Drawing.Size(900, 660);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle, lblPatientID, lblPatientName, lblAge, lblGender, lblAddress;
        private System.Windows.Forms.TextBox txtPatientID, txtPatientName, txtAge, txtGender, txtAddress;
        private System.Windows.Forms.Button btnInsert, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.DataGridView dgvPatients;
    }
}
