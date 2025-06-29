USE EmployeeDB;
GO

-- Insert Departments
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

-- Insert Employees (without specifying EmployeeID)
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 500000, '2020-01-15'),
('Jane', 'Smith', 2, 600000, '2019-03-22'),
('Michael', 'Johnson', 3, 700000, '2018-07-30'),
('Emily', 'Davis', 4, 550000, '2021-11-05');
