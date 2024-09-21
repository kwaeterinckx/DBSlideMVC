CREATE PROCEDURE [dbo].[SP_Student_GetById]
	@StudentId INT
AS
BEGIN
	SELECT *
	FROM [Student]
	WHERE [StudentId] = @StudentId
END
