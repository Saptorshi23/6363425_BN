USE EmployeeDB;
GO

-- Execute the procedure to insert Arjun Verma
EXEC sp_InsertEmployee
    @FirstName = 'Arjun',
    @LastName = 'Verma',
    @DepartmentID = 2,
    @Salary = 480000,
    @JoinDate = '2024-06-01';
