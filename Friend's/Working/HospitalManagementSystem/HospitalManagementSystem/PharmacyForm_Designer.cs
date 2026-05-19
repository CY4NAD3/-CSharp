namespace HospitalManagementSystem
{
    partial class PharmacyForm
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
            lblMedicine = new System.Windows.Forms.Label();
            txtMedicineName = new System.Windows.Forms.TextBox();
            lblBatch = new System.Windows.Forms.Label();
            txtBatchNumber = new System.Windows.Forms.TextBox();
            lblExpiry = new System.Windows.Forms.Label();
            dtpExpiry = new System.Windows.Forms.DateTimePicker();
            lblQty = new System.Windows.Forms.Label();
            nudQuantity = new System.Windows.Forms.NumericUpDown();
            btnSave = new System.Windows.Forms.Button();
            btnCheckExpiry = new System.Windows.Forms.Button();
            dgvPharmacy = new System.Windows.Forms.DataGridView();

            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPharmacy).BeginInit();
            SuspendLayout();

            panelHeader.BackColor = System.Drawing.Color.DarkGreen;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Height = 55;

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 10);
            lblTitle.Text = "Pharmacy Expiry Tracker";

            string[] lbTxts = { "Medicine Name:", "Batch Number:", "Expiry Date:", "Quantity:" };
            System.Windows.Forms.Label[] lbs = { lblMedicine, lblBatch, lblExpiry, lblQty };
            for (int i = 0; i < lbs.Length; i++)
            {
                lbs[i].AutoSize = true;
                lbs[i].Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                lbs[i].Location = new System.Drawing.Point(15, 68 + i * 40);
                lbs[i].Text = lbTxts[i];
            }
            txtMedicineName.Location = new System.Drawing.Point(160, 65); txtMedicineName.Size = new System.Drawing.Size(220, 27); txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtBatchNumber.Location  = new System.Drawing.Point(160, 105); txtBatchNumber.Size  = new System.Drawing.Size(220, 27); txtBatchNumber.Font  = new System.Drawing.Font("Segoe UI", 9F);
            dtpExpiry.Location       = new System.Drawing.Point(160, 143); dtpExpiry.Size       = new System.Drawing.Size(220, 27); dtpExpiry.Font       = new System.Drawing.Font("Segoe UI", 9F); dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            nudQuantity.Location     = new System.Drawing.Point(160, 183); nudQuantity.Size     = new System.Drawing.Size(100, 27); nudQuantity.Font     = new System.Drawing.Font("Segoe UI", 9F); nudQuantity.Minimum = 1; nudQuantity.Maximum = 10000;

            btnSave.Text = "💾 Save Medicine"; btnSave.Location = new System.Drawing.Point(15, 240); btnSave.Size = new System.Drawing.Size(150, 35);
            btnSave.BackColor = System.Drawing.Color.ForestGreen; btnSave.ForeColor = System.Drawing.Color.White; btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSave.Click += new System.EventHandler(this.btnSave_Click);

            btnCheckExpiry.Text = "⚠ Check Expiring"; btnCheckExpiry.Location = new System.Drawing.Point(175, 240); btnCheckExpiry.Size = new System.Drawing.Size(160, 35);
            btnCheckExpiry.BackColor = System.Drawing.Color.OrangeRed; btnCheckExpiry.ForeColor = System.Drawing.Color.White; btnCheckExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckExpiry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnCheckExpiry.Click += new System.EventHandler(this.btnCheckExpiry_Click);

            dgvPharmacy.Location = new System.Drawing.Point(0, 295);
            dgvPharmacy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            dgvPharmacy.Size = new System.Drawing.Size(900, 350);
            dgvPharmacy.ReadOnly = true;
            dgvPharmacy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPharmacy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelHeader);
            foreach (var l in lbs) Controls.Add(l);
            Controls.Add(txtMedicineName); Controls.Add(txtBatchNumber);
            Controls.Add(dtpExpiry); Controls.Add(nudQuantity);
            Controls.Add(btnSave); Controls.Add(btnCheckExpiry);
            Controls.Add(dgvPharmacy);
            Size = new System.Drawing.Size(900, 660);

            panelHeader.ResumeLayout(false); panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPharmacy).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle, lblMedicine, lblBatch, lblExpiry, lblQty;
        private System.Windows.Forms.TextBox txtMedicineName, txtBatchNumber;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnSave, btnCheckExpiry;
        private System.Windows.Forms.DataGridView dgvPharmacy;
    }
}
