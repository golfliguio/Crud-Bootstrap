CREATE TABLE [dbo].[Pessoa]
(
	[Codigo] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NULL, 
    [Endereco] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL
)
