CREATE TABLE [dbo].[Course]
(
	[CourseId] NVARCHAR(6) NOT NULL ,
	[CourseName] NVARCHAR(200) NOT NULL ,
	[CourseEcts] DECIMAL(3,1) NOT NULL,
	[ProfessorId] INT NOT NULL,
	CONSTRAINT PK_Course PRIMARY KEY ([CourseId]),
	CONSTRAINT FK_Course_Professor FOREIGN KEY ([ProfessorId]) REFERENCES [Professor]([ProfessorId])
)
