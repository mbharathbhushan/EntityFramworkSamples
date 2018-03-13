CREATE TABLE [dbo].[ContractEmployees] (
    [EmployeeID]  INT NOT NULL,
    [HourlyPay]   INT NULL,
    [HoursWorked] INT NULL,
    FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

