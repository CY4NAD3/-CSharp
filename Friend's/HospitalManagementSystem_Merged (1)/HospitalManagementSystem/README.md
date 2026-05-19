# Hospital Management System – Merged Project

## What's Included

| Module | Source Zip | Database |
|---|---|---|
| Login | login2.zip | DemoDB → Users |
| Doctor Management | Doctor__2_.zip | HospitalDB → Doctors |
| Patient Management | ProjectPatient__1_.zip | HospitalDB → patients |
| Appointment Management | Appointment.zip | HospitalDB → Appointments |
| Billing | Billing22.zip | BillingDB → Billing |
| Pharmacy Expiry Tracker | Form1_1.zip | master → PharmacyExpiryData |

## Quick Setup

### 1. Database
1. Open **SQL Server Management Studio**
2. Connect to `localhost\SQLEXPRESS`
3. Open `DatabaseSetup.sql` and run it (F5)
4. All databases and tables will be created automatically

### 2. Project
1. Open **Visual Studio**
2. Open `HospitalManagementSystem/HospitalManagementSystem.csproj`
3. Right-click project → **Manage NuGet Packages**
4. Install `Microsoft.Data.SqlClient` (version 5.x)
   > Note: PharmacyForm still uses `System.Data.SqlClient` (old .NET Framework style).
   > If needed, change `using System.Data.SqlClient` in `PharmacyForm.cs` to `Microsoft.Data.SqlClient`
5. Build & Run (F5)

### 3. Default Login
- Username: `admin`
- Password: `admin123`

## Connection Strings

All connections are centralized in **`DbHelper.cs`**:
```csharp
GetAuthConnection()     → DemoDB       (login)
GetHospitalConnection() → HospitalDB   (doctors, patients, appointments)
GetBillingConnection()  → BillingDB    (billing)
```
PharmacyForm uses its own connection string – change it inside `PharmacyForm.cs` if needed.

## Project Structure

```
HospitalManagementSystem/
├── Program.cs
├── DbHelper.cs               ← Centralized connection strings
├── LoginForm.cs / .Designer.cs
├── Dashboard.cs / .Designer.cs
├── DoctorForm.cs / .Designer.cs       (UserControl)
├── PatientForm.cs / .Designer.cs      (UserControl)
├── BillingForm.cs / .Designer.cs      (UserControl)
├── AppointmentForm.cs / .Designer.cs  (UserControl)
├── PharmacyForm.cs / .Designer.cs     (UserControl)
└── HospitalManagementSystem.csproj
DatabaseSetup.sql
README.md
```
