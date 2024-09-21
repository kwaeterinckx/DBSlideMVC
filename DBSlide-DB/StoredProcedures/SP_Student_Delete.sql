CREATE PROCEDURE [dbo].[SP_Student_Delete]
	@StudentId INT
AS
BEGIN
	DELETE FROM [Student]
	WHERE [StudentId] = @StudentId
END