CREATE TABLE [dbo].[Student] (
  [StudentId] INT NOT NULL IDENTITY,
  [FirstName] NVARCHAR(50) NOT NULL,
  [LastName] NVARCHAR(50) NOT NULL,
  [BirthDate] DATE NOT NULL,
  [Login] NVARCHAR(50) NOT NULL,
  [SectionId] INT NOT NULL,
  [YearResult] INT,
  [CourseId] NVARCHAR(6),
  CONSTRAINT PK_Student PRIMARY KEY ([StudentId]),
  CONSTRAINT FK_Student_Section FOREIGN KEY ([SectionId]) REFERENCES [Section]([SectionId]),
  CONSTRAINT FK_Student_Course FOREIGN KEY ([CourseId]) REFERENCES [Course]([CourseId]),
  CONSTRAINT CK_Student_YearResult CHECK ([YearResult] BETWEEN 0 AND 20)
)