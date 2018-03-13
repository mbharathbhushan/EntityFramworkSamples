CREATE TABLE [dbo].[PermanentEmployees] (
    [EmployeeID]   INT NOT NULL,
    [AnnualSalary] INT NULL,
    FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

