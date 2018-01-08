CREATE TABLE [dbo].[tbl_Authors_Books_Relation] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [AuthorId] INT NOT NULL,
    [BookId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT  FK_tbl_Autors_Books_Relation_tbl_Author FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[tbl_Author] ([Id]),
    CONSTRAINT  FK_tbl_Autors_Books_Relation_tbl_Book FOREIGN KEY ([BookId]) REFERENCES [dbo].[tbl_Book] ([Id])
);

