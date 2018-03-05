CREATE TABLE [dbo].[Employees] (
    [EmployeeID] INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (50) NULL,
    [LastName]   NVARCHAR (50) NULL,
    [Gender]     NVARCHAR (50) NULL,
    [Email]      NVARCHAR (50) NULL,
    [Mobile]     NVARCHAR (50) NULL,
    [LandLine]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

