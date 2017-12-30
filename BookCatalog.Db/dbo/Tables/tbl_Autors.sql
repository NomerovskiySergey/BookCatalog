CREATE TABLE [dbo].[tbl_Autors] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (MAX) NOT NULL,
    [LastName]  VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

