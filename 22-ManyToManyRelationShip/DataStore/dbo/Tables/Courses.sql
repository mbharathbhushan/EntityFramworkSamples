CREATE TABLE [dbo].[Courses] (
    [CourseID]   INT           IDENTITY (1, 1) NOT NULL,
    [CourseName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CourseID] ASC)
);

