CREATE TABLE [dbo].[tbl_Books] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR (MAX) NOT NULL,
    [ReleaseDate] DATETIME      NOT NULL,
    [Rating]      INT           NOT NULL,
    [PageCount]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

