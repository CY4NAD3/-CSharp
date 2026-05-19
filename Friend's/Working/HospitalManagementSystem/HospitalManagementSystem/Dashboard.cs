using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
        }

        // ── Navigation helpers ────────────────────────────────────────────────
        private void LoadPanel(Control form)
        {
            panelContent.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
        }

        private void HighlightButton(Button active)
        {
            foreach (Control c in panelSidebar.Controls)
                if (c is Button b) b.BackColor = Color.FromArgb(0, 102, 204);
            active.BackColor = Color.FromArgb(0, 60, 130);
        }

        // ── Sidebar buttons ───────────────────────────────────────────────────
        private void btnDoctor_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDoctor);
            LoadPanel(new DoctorForm());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPatient);
            LoadPanel(new PatientForm());
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            HighlightButton(btnBilling);
            LoadPanel(new BillingForm());
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            HighlightButton(btnAppointment);
            LoadPanel(new AppointmentForm());
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPharmacy);
            LoadPanel(new PharmacyForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
