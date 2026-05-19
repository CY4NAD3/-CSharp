using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class PatientForm : UserControl
    {
        public PatientForm()
        {
            InitializeComponent();
            LoadPatientData();
        }

        void LoadPatientData()
        {
            try
            {
                using SqlConnection conn = DbHelper.GetHospitalConnection();
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM patients", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPatients.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = DbHelper.GetHospitalConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO patients(patientid,patientname,age,gender,address) VALUES(@id,@name,@age,@gender,@address)", conn);
                cmd.Parameters.AddWithValue("@id",      int.Parse(txtPatientID.Text));
                cmd.Parameters.AddWithValue("@name",    txtPatientName.Text);
                cmd.Parameters.AddWithValue("@age",     int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@gender",  txtGender.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully!");
                LoadPatientData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = DbHelper.GetHospitalConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE patients SET patientname=@name,age=@age,gender=@gender,address=@address WHERE patientid=@id", conn);
                cmd.Parameters.AddWithValue("@id",      int.Parse(txtPatientID.Text));
                cmd.Parameters.AddWithValue("@name",    txtPatientName.Text);
                cmd.Parameters.AddWithValue("@age",     int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@gender",  txtGender.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");
                LoadPatientData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = DbHelper.GetHospitalConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM patients WHERE patientid=@id", conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtPatientID.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully!");
                LoadPatientData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtAge.Clear();
            txtGender.Clear();
            txtAddress.Clear();
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPatients.Rows[e.RowIndex];
                txtPatientID.Text   = row.Cells[0].Value?.ToString();
                txtPatientName.Text = row.Cells[1].Value?.ToString();
                txtAge.Text         = row.Cells[2].Value?.ToString();
                txtGender.Text      = row.Cells[3].Value?.ToString();
                txtAddress.Text     = row.Cells[4].Value?.ToString();
            }
        }
    }
}
