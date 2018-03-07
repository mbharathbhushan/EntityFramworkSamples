﻿CREATE TABLE [dbo].[Employees] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]     NVARCHAR (50) NULL,
    [LastName]      NVARCHAR (50) NULL,
    [Gender]        NVARCHAR (50) NULL,
    [AnuualSalary]  INT           NULL,
    [HourlyPay]     INT           NULL,
    [HoursWorked]   INT           NULL,
    [Discriminator] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

