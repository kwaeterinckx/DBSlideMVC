CREATE TABLE [dbo].[Grade] (
  [Grade] CHAR(2) NOT NULL ,
  [LowerBound] INT NOT NULL,
  [UpperBound] INT NOT NULL,
  CONSTRAINT PK_Grade PRIMARY KEY ([Grade])
)