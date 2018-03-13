CREATE TABLE [dbo].[Employees] (
    [EmployeeID] INT           NOT NULL,
    [FirstName]  NVARCHAR (50) NULL,
    [LastName]   NVARCHAR (50) NULL,
    [Gender]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

