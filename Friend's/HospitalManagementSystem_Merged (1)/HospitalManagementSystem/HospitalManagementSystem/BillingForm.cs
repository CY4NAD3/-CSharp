using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class BillingForm : UserControl
    {
        public BillingForm()
        {
            InitializeComponent();
            LoadBills();
        }

        void LoadBills()
        {
            try
            {
                using SqlConnection con = DbHelper.GetBillingConnection();
                con.Open();
                DataTable dt = new DataTable();
                new SqlDataAdapter("SELECT * FROM Billing", con).Fill(dt);
                dgvBills.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDoctor.Text, out double d) && double.TryParse(txtMedicine.Text, out double m))
                txtTotal.Text = (d + m).ToString("F2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPatient.Text == "" || txtDoctor.Text == "" || txtMedicine.Text == "")
                { MessageBox.Show("Please fill all fields!"); return; }

                double total  = Convert.ToDouble(txtTotal.Text);
                double paid   = txtPaid.Text == "" ? 0 : Convert.ToDouble(txtPaid.Text);
                double due    = total - paid;
                string status = due <= 0 ? "Paid" : "Unpaid";

                using SqlConnection con = DbHelper.GetBillingConnection();
                con.Open();

                // Duplicate check
                SqlCommand chk = new SqlCommand(
                    "SELECT COUNT(*) FROM Billing WHERE PatientName=@n AND DoctorFee=@d AND MedicineCharge=@m AND TotalAmount=@t", con);
                chk.Parameters.AddWithValue("@n", txtPatient.Text);
                chk.Parameters.AddWithValue("@d", Convert.ToDouble(txtDoctor.Text));
                chk.Parameters.AddWithValue("@m", Convert.ToDouble(txtMedicine.Text));
                chk.Parameters.AddWithValue("@t", total);
                if ((int)chk.ExecuteScalar() > 0) { MessageBox.Show("This bill already exists!"); return; }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Billing (PatientName,DoctorFee,MedicineCharge,TotalAmount,BillingDate,PaidAmount,DueAmount,Status) " +
                    "VALUES (@name,@doc,@med,@tot,@date,@paid,@due,@status)", con);
                cmd.Parameters.AddWithValue("@name",   txtPatient.Text);
                cmd.Parameters.AddWithValue("@doc",    Convert.ToDouble(txtDoctor.Text));
                cmd.Parameters.AddWithValue("@med",    Convert.ToDouble(txtMedicine.Text));
                cmd.Parameters.AddWithValue("@tot",    total);
                cmd.Parameters.AddWithValue("@date",   DateTime.Now);
                cmd.Parameters.AddWithValue("@paid",   paid);
                cmd.Parameters.AddWithValue("@due",    due);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Saved Successfully!\nStatus: {status}\nDue: {due:F2}");
                LoadBills();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatient.Clear(); txtDoctor.Clear();
            txtMedicine.Clear(); txtTotal.Clear(); txtPaid.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection con = DbHelper.GetBillingConnection();
                con.Open();
                DataTable dt = new DataTable();
                new SqlDataAdapter(
                    "SELECT * FROM Billing WHERE PatientName LIKE '%" + txtSearch.Text + "%'", con).Fill(dt);
                dgvBills.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBills.SelectedRows[0];
                string bill =
                    "========== HOSPITAL BILL ==========\n\n" +
                    "Date        : " + row.Cells["BillingDate"].Value + "\n" +
                    "Patient     : " + row.Cells["PatientName"].Value + "\n" +
                    "Doctor Fee  : " + row.Cells["DoctorFee"].Value + "\n" +
                    "Medicine    : " + row.Cells["MedicineCharge"].Value + "\n" +
                    "Total Amount: " + row.Cells["TotalAmount"].Value + "\n" +
                    "Paid Amount : " + row.Cells["PaidAmount"].Value + "\n" +
                    "Due Amount  : " + row.Cells["DueAmount"].Value + "\n" +
                    "Status      : " + row.Cells["Status"].Value + "\n\n" +
                    "===================================";
                MessageBox.Show(bill, "Bill Receipt");
            }
            else { MessageBox.Show("Please select a row from the table!"); }
        }
    }
}
