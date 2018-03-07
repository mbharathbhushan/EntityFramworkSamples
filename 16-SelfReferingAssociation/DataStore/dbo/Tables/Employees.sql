CREATE TABLE [dbo].[Employees] (
    [EmployeeID]   INT           IDENTITY (1, 1) NOT NULL,
    [EmployeeName] NVARCHAR (50) NULL,
    [ManagerID]    INT           NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC),
    FOREIGN KEY ([ManagerID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

