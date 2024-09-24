CREATE PROCEDURE [dbo].[SP_Student_GetAll]
AS
BEGIN
	SELECT *
	FROM [Student]
	JOIN [Section]
		ON [Student].[SectionId] = [Section].[SectionId]
END
