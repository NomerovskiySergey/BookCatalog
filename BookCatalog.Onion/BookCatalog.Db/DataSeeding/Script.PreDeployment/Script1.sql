CREATE TABLE #tbl_Autors (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (MAX) NOT NULL,
    [LastName]  NVARCHAR(MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

SELECT * INTO #tbl_Autors
FROM #tbl_Autors

DELETE FROM tbl_Autors