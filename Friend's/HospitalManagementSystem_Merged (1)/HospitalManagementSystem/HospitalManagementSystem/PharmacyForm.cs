using System.Data.SqlClient;   // PharmacyExpiryTracker used old System.Data.SqlClient
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class PharmacyForm : UserControl
    {
        // NOTE: PharmacyExpiryData table is in the master DB as originally coded.
        // Change this connection string if you move the table to HospitalDB.
        readonly string connStr = @"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";

        public PharmacyForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCheckExpiry_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection con = new SqlConnection(connStr);
                string query = "SELECT MedicineName,BatchNumber,ExpiryDate,Quantity FROM PharmacyExpiryData WHERE ExpiryDate <= DATEADD(day,AlertDays,GETDATE())";
                using SqlCommand cmd = new SqlCommand(query, con);
                using SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPharmacy.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
