CREATE TABLE [dbo].[Students] (
    [StudentID]   INT           IDENTITY (1, 1) NOT NULL,
    [StudentName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

