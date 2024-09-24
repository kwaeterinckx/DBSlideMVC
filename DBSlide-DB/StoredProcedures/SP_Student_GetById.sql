CREATE PROCEDURE [dbo].[SP_Student_GetById]
	@StudentId INT
AS
BEGIN
	SELECT *
	FROM [Student]
	JOIN [Section]
		ON [Student].[SectionId] = [Section].[SectionId]
	WHERE [StudentId] = @StudentId
END
