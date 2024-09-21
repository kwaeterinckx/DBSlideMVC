CREATE PROCEDURE [dbo].[SP_Student_Create]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@BirthDate DATE,
	@Login NVARCHAR(50),
	@SectionId INT,
	@YearResult INT = NULL,
	@CourseId NVARCHAR(6) = NULL
AS
BEGIN
	INSERT INTO [Student]([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId])
	OUTPUT [inserted].[StudentId]
	VALUES (@FirstName, @LastName, @BirthDate, @Login, @SectionId, @YearResult, @CourseId)
END
