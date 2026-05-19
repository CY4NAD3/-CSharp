using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class DoctorForm : UserControl
    {
        public DoctorForm()
        {
            InitializeComponent();
            LoadDoctorData();
        }

        void LoadDoctorData()
        {
            try
            {
                using SqlConnection con = DbHelper.GetHospitalConnection();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doctors", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoctors.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection con = DbHelper.GetHospitalConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Doctors VALUES(@id,@name,@gender,@spec,@room,@time)", con);
                cmd.Parameters.AddWithValue("@id", txtDoctorID.Text);
                cmd.Parameters.AddWithValue("@name", txtDoctorName.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@spec", txtSpecialization.Text);
                cmd.Parameters.AddWithValue("@room", txtRoomNo.Text);
                cmd.Parameters.AddWithValue("@time", cmbAvailableTime.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Added Successfully!");
                LoadDoctorData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection con = DbHelper.GetHospitalConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Doctors WHERE DoctorID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtDoctorID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoctors.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection con = DbHelper.GetHospitalConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Doctors SET DoctorName=@name,Gender=@gender,
                      Specialization=@spec,RoomNo=@room,AvailableTime=@time
                      WHERE DoctorID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtDoctorID.Text);
                cmd.Parameters.AddWithValue("@name", txtDoctorName.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@spec", txtSpecialization.Text);
                cmd.Parameters.AddWithValue("@room", txtRoomNo.Text);
                cmd.Parameters.AddWithValue("@time", cmbAvailableTime.Text);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Doctor Updated Successfully!" : "Doctor ID Not Found");
                LoadDoctorData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection con = DbHelper.GetHospitalConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Doctors WHERE DoctorID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtDoctorID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Deleted!");
                LoadDoctorData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDoctorID.Clear();
            txtDoctorName.Clear();
            txtSpecialization.Clear();
            txtRoomNo.Clear();
            cmbGender.SelectedIndex = -1;
            cmbAvailableTime.SelectedIndex = -1;
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDoctors.Rows[e.RowIndex];
                txtDoctorID.Text    = row.Cells[0].Value?.ToString();
                txtDoctorName.Text  = row.Cells[1].Value?.ToString();
                cmbGender.Text      = row.Cells[2].Value?.ToString();
                txtSpecialization.Text = row.Cells[3].Value?.ToString();
                txtRoomNo.Text      = row.Cells[4].Value?.ToString();
                cmbAvailableTime.Text  = row.Cells[5].Value?.ToString();
            }
        }
    }
}
