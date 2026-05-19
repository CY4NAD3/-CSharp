namespace HospitalManagementSystem
{
    partial class BillingForm
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
            lblMedicine = new System.Windows.Forms.Label();
            txtMedicine = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            lblPaid = new System.Windows.Forms.Label();
            txtPaid = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnCalculate = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnPrint = new System.Windows.Forms.Button();
            dgvBills = new System.Windows.Forms.DataGridView();

            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Height = 55;

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 10);
            lblTitle.Text = "Billing Management";

            // Left column labels & inputs
            string[] leftLabels = { "Patient Name:", "Doctor Fee:", "Medicine Charge:", "Total Amount:", "Paid Amount:" };
            System.Windows.Forms.Label[] lbs = { lblPatient, lblDoctor, lblMedicine, lblTotal, lblPaid };
            System.Windows.Forms.TextBox[] txts = { txtPatient, txtDoctor, txtMedicine, txtTotal, txtPaid };
            for (int i = 0; i < lbs.Length; i++)
            {
                lbs[i].AutoSize = true;
                lbs[i].Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                lbs[i].Location = new System.Drawing.Point(15, 68 + i * 40);
                lbs[i].Text = leftLabels[i];
                txts[i].Location = new System.Drawing.Point(165, 65 + i * 40);
                txts[i].Size = new System.Drawing.Size(200, 27);
                txts[i].Font = new System.Drawing.Font("Segoe UI", 9F);
            }
            txtTotal.ReadOnly = true;

            // Search
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            lblSearch.Location = new System.Drawing.Point(400, 68);
            lblSearch.Text = "Search Patient:";
            txtSearch.Location = new System.Drawing.Point(510, 65);
            txtSearch.Size = new System.Drawing.Size(200, 27);
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Buttons
            btnCalculate.Text = "Calculate"; btnCalculate.Location = new System.Drawing.Point(15, 275); btnCalculate.Size = new System.Drawing.Size(90, 32);
            btnCalculate.BackColor = System.Drawing.Color.DodgerBlue; btnCalculate.ForeColor = System.Drawing.Color.White;
            btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            btnSave.Text = "Save"; btnSave.Location = new System.Drawing.Point(115, 275); btnSave.Size = new System.Drawing.Size(80, 32);
            btnSave.BackColor = System.Drawing.Color.ForestGreen; btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            btnClear.Text = "Clear"; btnClear.Location = new System.Drawing.Point(205, 275); btnClear.Size = new System.Drawing.Size(80, 32);
            btnClear.BackColor = System.Drawing.Color.Gray; btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            btnSearch.Text = "Search"; btnSearch.Location = new System.Drawing.Point(720, 63); btnSearch.Size = new System.Drawing.Size(80, 32);
            btnSearch.BackColor = System.Drawing.Color.DodgerBlue; btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            btnPrint.Text = "🖨 Print"; btnPrint.Location = new System.Drawing.Point(810, 63); btnPrint.Size = new System.Drawing.Size(90, 32);
            btnPrint.BackColor = System.Drawing.Color.DarkSlateBlue; btnPrint.ForeColor = System.Drawing.Color.White;
            btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            btnSave.Click      += new System.EventHandler(this.btnSave_Click);
            btnClear.Click     += new System.EventHandler(this.btnClear_Click);
            btnSearch.Click    += new System.EventHandler(this.btnSearch_Click);
            btnPrint.Click     += new System.EventHandler(this.btnPrint_Click);

            foreach (var b in new[] { btnCalculate, btnSave, btnClear, btnSearch, btnPrint })
                b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // DataGridView
            dgvBills.Location = new System.Drawing.Point(0, 325);
            dgvBills.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            dgvBills.Size = new System.Drawing.Size(940, 320);
            dgvBills.ReadOnly = true;
            dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelHeader);
            foreach (var l in lbs) Controls.Add(l);
            foreach (var t in txts) Controls.Add(t);
            Controls.Add(lblSearch); Controls.Add(txtSearch);
            Controls.Add(btnCalculate); Controls.Add(btnSave); Controls.Add(btnClear);
            Controls.Add(btnSearch); Controls.Add(btnPrint);
            Controls.Add(dgvBills);
            Size = new System.Drawing.Size(940, 660);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle, lblPatient, lblDoctor, lblMedicine, lblTotal, lblPaid, lblSearch;
        private System.Windows.Forms.TextBox txtPatient, txtDoctor, txtMedicine, txtTotal, txtPaid, txtSearch;
        private System.Windows.Forms.Button btnCalculate, btnSave, btnClear, btnSearch, btnPrint;
        private System.Windows.Forms.DataGridView dgvBills;
    }
}
