CREATE PROCEDURE [dbo].[SP_Student_Update]
	@StudentId INT,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@BirthDate DATE,
	@Login NVARCHAR(50),
	@SectionId INT,
	@YearResult INT = NULL,
	@CourseId NVARCHAR(6) = NULL
AS
BEGIN
	UPDATE [Student]
	SET 
		[FirstName] = @FirstName,
		[LastName] = @LastName,
		[BirthDate] = @BirthDate,
		[Login] = @Login,
		[SectionId] = @SectionId,
		[YearResult] = @YearResult,
		[CourseId] = @CourseId
	OUTPUT [inserted].[StudentId]
	WHERE [StudentId] = @StudentId
END
