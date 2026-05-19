-- ============================================================
--  Hospital Management System – Full Database Setup Script
--  Run this in SQL Server Management Studio (SSMS)
--  Server: localhost\SQLEXPRESS
-- ============================================================

-- ── 1. DemoDB  (Login / Auth) ─────────────────────────────────────────────
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'DemoDB')
    CREATE DATABASE DemoDB;
GO
USE DemoDB;
GO
IF OBJECT_ID('Users','U') IS NULL
CREATE TABLE Users (
    Id       INT IDENTITY(1,1) PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL
);
GO
-- Default admin user (change password after first login!)
IF NOT EXISTS (SELECT 1 FROM Users WHERE UserName = 'admin')
    INSERT INTO Users (UserName, Password) VALUES ('admin', 'admin123');
GO


-- ── 2. HospitalDB  (Doctors, Patients, Appointments) ─────────────────────
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'HospitalDB')
    CREATE DATABASE HospitalDB;
GO
USE HospitalDB;
GO

-- Doctors
IF OBJECT_ID('Doctors','U') IS NULL
CREATE TABLE Doctors (
    DoctorID       INT          PRIMARY KEY,
    DoctorName     VARCHAR(100),
    Gender         VARCHAR(20),
    Specialization VARCHAR(100),
    RoomNo         VARCHAR(20),
    AvailableTime  VARCHAR(50)
);
GO

-- Patients
IF OBJECT_ID('patients','U') IS NULL
CREATE TABLE patients (
    patientid   INT          NOT NULL,
    patientname VARCHAR(50)  NOT NULL,
    age         INT          NOT NULL,
    gender      VARCHAR(50)  NOT NULL,
    address     VARCHAR(50)  NOT NULL,
    CONSTRAINT PK_patients PRIMARY KEY (patientid)
);
GO

-- Appointments
IF OBJECT_ID('Appointments','U') IS NULL
CREATE TABLE Appointments (
    AppointmentID   INT IDENTITY(1,1) PRIMARY KEY,
    PatientName     VARCHAR(100),
    DoctorName      VARCHAR(100),
    AppointmentDate DATE,
    AppointmentTime VARCHAR(20),
    Status          VARCHAR(20)  DEFAULT 'Scheduled',
    Notes           VARCHAR(500)
);
GO


-- ── 3. BillingDB ──────────────────────────────────────────────────────────
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'BillingDB')
    CREATE DATABASE BillingDB;
GO
USE BillingDB;
GO
IF OBJECT_ID('Billing','U') IS NULL
CREATE TABLE Billing (
    BillingID      INT IDENTITY(1,1) PRIMARY KEY,
    PatientName    VARCHAR(100),
    DoctorFee      DECIMAL(10,2),
    MedicineCharge DECIMAL(10,2),
    TotalAmount    DECIMAL(10,2),
    BillingDate    DATETIME DEFAULT GETDATE(),
    PaidAmount     DECIMAL(10,2),
    DueAmount      DECIMAL(10,2),
    Status         VARCHAR(20)
);
GO


-- ── 4. PharmacyExpiryData  (in master DB, same as original code) ──────────
USE master;
GO
IF OBJECT_ID('PharmacyExpiryData','U') IS NULL
CREATE TABLE PharmacyExpiryData (
    Id           INT IDENTITY(1,1) PRIMARY KEY,
    MedicineName VARCHAR(100),
    BatchNumber  VARCHAR(50),
    ExpiryDate   DATE,
    Quantity     INT,
    AlertDays    INT DEFAULT 30
);
GO

PRINT 'All databases and tables created successfully!';
