CREATE TABLE [dbo].[EmployeeContactDetails] (
    [EmployeeID] INT           NOT NULL,
    [Email]      NVARCHAR (50) NULL,
    [Mobile]     NVARCHAR (50) NULL,
    [LandLine]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

