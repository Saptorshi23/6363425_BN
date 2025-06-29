USE EmployeeDB;
GO

-- Drop tables if they already exist
DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;

-- Recreate Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

-- Recreate Employees table with auto-increment ID
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10, 2),
    JoinDate DATE
);
