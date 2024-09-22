CREATE PROCEDURE [dbo].[SP_Student_Login]
	@Login NVARCHAR(50)
AS
BEGIN
	SELECT [Login]
	FROM [Student]
	WHERE [Login] = @Login
END
