CREATE TABLE [dbo].[tbl_Autors_Books_Relation] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Autor] INT NOT NULL,
    [Book]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Autor]) REFERENCES [dbo].[tbl_Authors] ([Id]),
    FOREIGN KEY ([Book]) REFERENCES [dbo].[tbl_Books] ([Id])
);

