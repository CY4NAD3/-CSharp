using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class PharmacyForm : UserControl
    {
        // Moved to HospitalDB for consistency with the rest of the project
        readonly string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True;Trust Server Certificate=True";

        public PharmacyForm()
        {
            InitializeComponent();
            LoadAllMedicines();
        }

        void LoadAllMedicines()
        {
            try
            {
                using SqlConnection con = new SqlConnection(connStr);
                con.Open();
                DataTable dt = new DataTable();
                new SqlDataAdapter("SELECT MedicineName,BatchNumber,ExpiryDate,Quantity FROM PharmacyExpiryData", con).Fill(dt);
                dgvPharmacy.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMedicineName.Text) || string.IsNullOrWhiteSpace(txtBatchNumber.Text))
                { MessageBox.Show("Please fill all fields!"); return; }

                using SqlConnection con = new SqlConnection(connStr);
                string query = "INSERT INTO PharmacyExpiryData (MedicineName,BatchNumber,ExpiryDate,Quantity) VALUES (@Name,@Batch,@Expiry,@Qty)";
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name",   txtMedicineName.Text);
                cmd.Parameters.AddWithValue("@Batch",  txtBatchNumber.Text);
                cmd.Parameters.AddWithValue("@Expiry", dtpExpiry.Value.Date);
                cmd.Parameters.AddWithValue("@Qty",    (int)nudQuantity.Value);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully!");
                LoadAllMedicines();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCheckExpiry_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection con = new SqlConnection(connStr);
                con.Open();
                // Show medicines expiring within AlertDays (default 30 days per SQL setup)
                string query = "SELECT MedicineName,BatchNumber,ExpiryDate,Quantity FROM PharmacyExpiryData WHERE ExpiryDate <= DATEADD(day,AlertDays,GETDATE())";
                using SqlCommand cmd = new SqlCommand(query, con);
                using SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPharmacy.DataSource = dt;
                if (dt.Rows.Count == 0)
                    MessageBox.Show("No medicines expiring soon.");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
