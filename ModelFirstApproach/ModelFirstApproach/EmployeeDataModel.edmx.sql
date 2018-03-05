
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/27/2018 13:13:10
-- Generated from EDMX file: D:\EntityFramworkSamples\ModelFirstApproach\ModelFirstApproach\EmployeeDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirstApproach];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DepartmentEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_DepartmentEmployee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Departments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departments];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [DepartmentId] smallint  NOT NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Location] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartmentId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_DepartmentEmployee]
    FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentEmployee'
CREATE INDEX [IX_FK_DepartmentEmployee]
ON [dbo].[Employees]
    ([DepartmentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------