using Microsoft.Data.SqlClient;

namespace HospitalManagementSystem
{
    /// <summary>
    /// Centralized database connection helper.
    /// Connection strings use localhost\SQLEXPRESS – change as needed.
    /// </summary>
    internal static class DbHelper
    {
        // ── Main hospital database (Doctors, Patients, Appointments) ──────────
        public static SqlConnection GetHospitalConnection()
        {
            return new SqlConnection(
                @"Data Source=localhost\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True;Trust Server Certificate=True");
        }

        // ── Billing database ──────────────────────────────────────────────────
        public static SqlConnection GetBillingConnection()
        {
            return new SqlConnection(
                @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillingDB;Integrated Security=True;Trust Server Certificate=True");
        }

        // ── Auth / login database ─────────────────────────────────────────────
        public static SqlConnection GetAuthConnection()
        {
            return new SqlConnection(
                @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DemoDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
