using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class AppointmentForm : UserControl
    {
        public AppointmentForm()
        {
            InitializeComponent();
            LoadAppointments();
        }

        void LoadAppointments()
        {
            try
            {
                using SqlConnection con = DbHelper.GetHospitalConnection();
                con.Open();
                DataTable dt = new DataTable();
                new SqlDataAdapter("SELECT * FROM Appointments", con).Fill(dt);
                dgvAppointments.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPatient.Text == "" || txtDoctor.Text == "")
                { MessageBox.Show("Please fill all fields!"); return; }

                using SqlConnection con = DbHelper.GetHospitalConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Appointments (PatientName,DoctorName,AppointmentDate,AppointmentTime,Status,Notes) " +
                    "VALUES (@patient,@doctor,@date,@time,@status,@notes)", con);
                cmd.Parameters.AddWithValue("@patient", txtPatient.Text);
                cmd.Parameters.AddWithValue("@doctor",  txtDoctor.Text);
                cmd.Parameters.AddWithValue("@date",    dtpDate.Value.Date);
                cmd.Parameters.AddWithValue("@time",    txtTime.Text);
                cmd.Parameters.AddWithValue("@status",  cmbStatus.SelectedItem?.ToString() ?? "Scheduled");
                cmd.Parameters.AddWithValue("@notes",   txtNotes.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Appointment Saved Successfully!");
                LoadAppointments();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection con = DbHelper.GetHospitalConnection();
                con.Open();
                DataTable dt = new DataTable();
                new SqlDataAdapter(
                    "SELECT * FROM Appointments WHERE PatientName LIKE '%" + txtSearch.Text +
                    "%' OR DoctorName LIKE '%" + txtSearch.Text + "%'", con).Fill(dt);
                dgvAppointments.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        void ClearFields()
        {
            txtPatient.Clear(); txtDoctor.Clear();
            txtTime.Clear(); txtNotes.Clear(); txtSearch.Clear();
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            { MessageBox.Show("Please select a row to delete!"); return; }

            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
                    using SqlConnection con = DbHelper.GetHospitalConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Appointments WHERE AppointmentID=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!");
                    LoadAppointments();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
