CREATE TABLE [dbo].[StudentCourses] (
    [StudentID] INT NOT NULL,
    [CourseID]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC, [CourseID] ASC),
    FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Courses] ([CourseID]),
    FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Students] ([StudentID])
);

