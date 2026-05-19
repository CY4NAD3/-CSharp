namespace HospitalManagementSystem
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelSidebar = new System.Windows.Forms.Panel();
            panelTop = new System.Windows.Forms.Panel();
            lblAppName = new System.Windows.Forms.Label();
            panelContent = new System.Windows.Forms.Panel();
            btnDoctor = new System.Windows.Forms.Button();
            btnPatient = new System.Windows.Forms.Button();
            btnBilling = new System.Windows.Forms.Button();
            btnAppointment = new System.Windows.Forms.Button();
            btnPharmacy = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();

            panelSidebar.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();

            // panelTop
            panelTop.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            panelTop.Controls.Add(lblAppName);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Height = 55;

            // lblAppName
            lblAppName.AutoSize = true;
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblAppName.ForeColor = System.Drawing.Color.White;
            lblAppName.Location = new System.Drawing.Point(15, 12);
            lblAppName.Text = "🏥  Hospital Management System";

            // panelSidebar
            panelSidebar.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            panelSidebar.Controls.Add(btnDoctor);
            panelSidebar.Controls.Add(btnPatient);
            panelSidebar.Controls.Add(btnBilling);
            panelSidebar.Controls.Add(btnAppointment);
            panelSidebar.Controls.Add(btnPharmacy);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Width = 160;

            System.Windows.Forms.Button[] sideButtons = { btnDoctor, btnPatient, btnBilling, btnAppointment, btnPharmacy, btnLogout };
            string[] sideTexts = { "👨‍⚕️  Doctor", "🧑‍🤝‍🧑  Patient", "💰  Billing", "📅  Appointment", "💊  Pharmacy", "🚪  Logout" };
            for (int i = 0; i < sideButtons.Length; i++)
            {
                sideButtons[i].Text = sideTexts[i];
                sideButtons[i].Dock = System.Windows.Forms.DockStyle.Top;
                sideButtons[i].Height = 50;
                sideButtons[i].BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
                sideButtons[i].ForeColor = System.Drawing.Color.White;
                sideButtons[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                sideButtons[i].FlatAppearance.BorderSize = 0;
                sideButtons[i].Font = new System.Drawing.Font("Segoe UI", 10F);
                sideButtons[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sideButtons[i].Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            }
            // Re-order dock-top buttons (they stack bottom-up)
            btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;

            btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            btnPharmacy.Click += new System.EventHandler(this.btnPharmacy_Click);
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // panelContent
            panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContent.BackColor = System.Drawing.Color.WhiteSmoke;

            // Dashboard
            ClientSize = new System.Drawing.Size(1100, 680);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelTop);
            Text = "Dashboard - Hospital Management System";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += new System.EventHandler(this.Dashboard_Load);

            panelSidebar.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnPharmacy;
        private System.Windows.Forms.Button btnLogout;
    }
}
