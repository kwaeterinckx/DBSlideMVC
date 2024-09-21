CREATE TABLE [dbo].[Professor]
(
	[ProfessorId] INT NOT NULL IDENTITY,
	[ProfessorName] NVARCHAR(30) NOT NULL,
	[ProfessorSurname] NVARCHAR(30) NOT NULL,
	[SectionId] INT NOT NULL,
	[ProfessorOffice] INT NOT NULL,
	[ProfessorEmail] NVARCHAR(30) NOT NULL,
	[ProfessorHireDate] DATE NOT NULL,
	[ProfessorWage] INT NOT NULL,
	CONSTRAINT PK_Professor PRIMARY KEY (ProfessorId),
	CONSTRAINT FK_Professor_Section FOREIGN KEY (SectionId) REFERENCES [Section](SectionId)
)
