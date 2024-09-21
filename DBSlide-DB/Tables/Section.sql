CREATE TABLE [dbo].[Section] (
	[SectionId] INT NOT NULL,
	[SectionName] NVARCHAR(50) NULL,
	[DelegateId] INT NULL,
	CONSTRAINT PK_Section PRIMARY KEY (SectionId),
	CONSTRAINT FK_Section_Student FOREIGN KEY ([DelegateId]) REFERENCES [Student]([StudentId])
)