using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Appointment
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Server=.\sqlexpress;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True");

        public Form1()
        {
            InitializeComponent();
            LoadAppointments();
        }

        void LoadAppointments()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Appointments", con);
            da.Fill(dt);
            dgvAppointments.DataSource = dt;
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPatient.Text == "" || txtDoctor.Text == "")
                {
                    MessageBox.Show("Please fill all fields!");
                    return;
                }

                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = "INSERT INTO Appointments (PatientName, DoctorName, AppointmentDate, AppointmentTime, Status, Notes) " +
                               "VALUES (@patient, @doctor, @date, @time, @status, @notes)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@patient", txtPatient.Text);
                cmd.Parameters.AddWithValue("@doctor", txtDoctor.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                cmd.Parameters.AddWithValue("@time", txtTime.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@notes", txtNotes.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Appointment Saved Successfully!");
                LoadAppointments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Appointments WHERE PatientName LIKE '%" + txtSearch.Text + "%' OR DoctorName LIKE '%" + txtSearch.Text + "%'", con);
            da.Fill(dt);
            dgvAppointments.DataSource = dt;
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtPatient.Clear();
            txtDoctor.Clear();
            txtTime.Clear();
            txtNotes.Clear();
            txtSearch.Clear();
            cmbStatus.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete!");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Appointments WHERE AppointmentID=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted Successfully!");
                LoadAppointments();
            }
        }
    }
}