IF NOT EXISTS(SELECT 1 FROM [tbl_Authors_Books_Relation])
BEGIN

	IF EXISTS (SELECT [Id] FROM [dbo].[tbl_Author] WHERE LOWER([FirstName]) = LOWER('Эмануил') AND LOWER([LastName]) = LOWER('Бланк'))
	BEGIN
	 INSERT INTO [dbo].[tbl_Authors_Books_Relation]([AuthorId],[BookId])
	 SELECT A.[Id], B.[Id]
	 FROM [tbl_Author] AS A
	 INNER JOIN [tbl_Book] AS B ON ((LOWER(A.[FirstName]) = LOWER('Эмануил') AND LOWER(A.[LastName]) = LOWER('Бланк'))
									AND 
									(LOWER(B.[Title]) = LOWER('Книга 1') OR LOWER(B.[Title]) = LOWER('Книга 2') OR LOWER(B.[Title]) = LOWER('Книга 3')))
	END

	IF EXISTS (SELECT [Id] FROM [dbo].[tbl_Author] WHERE LOWER([FirstName]) = LOWER('Алекс') AND LOWER([LastName]) = LOWER('Шуваевский'))
	BEGIN
	 INSERT INTO [dbo].[tbl_Authors_Books_Relation]([AuthorId],[BookId])
	 SELECT A.[Id], B.[Id]
	 FROM [tbl_Author] AS A
	 INNER JOIN [tbl_Book] AS B ON ((LOWER(A.[FirstName]) = LOWER('Алекс') AND LOWER(A.[LastName]) = LOWER('Шуваевский'))
									AND 
									(LOWER(B.[Title]) = LOWER('Книга 4') OR LOWER(B.[Title]) = LOWER('Книга 5') OR LOWER(B.[Title]) = LOWER('Книга 6')))
	END

	IF EXISTS (SELECT [Id] FROM [dbo].[tbl_Author] WHERE LOWER([FirstName]) = LOWER('Евгения') AND LOWER([LastName]) = LOWER('Серенко'))
	BEGIN
	 INSERT INTO [dbo].[tbl_Authors_Books_Relation]([AuthorId],[BookId])
	 SELECT A.[Id], B.[Id]
	 FROM [tbl_Author] AS A
	 INNER JOIN [tbl_Book] AS B ON ((LOWER(A.[FirstName]) = LOWER('Евгения') AND LOWER(A.[LastName]) = LOWER('Серенко'))
									AND 
									(LOWER(B.[Title]) = LOWER('Книга 7') OR LOWER(B.[Title]) = LOWER('Книга 8') OR LOWER(B.[Title]) = LOWER('Книга 9')))
	END

	IF EXISTS (SELECT [Id] FROM [dbo].[tbl_Author] WHERE LOWER([FirstName]) = LOWER('Эмануил') AND LOWER([LastName]) = LOWER('Бланк'))
	BEGIN
	 INSERT INTO [dbo].[tbl_Authors_Books_Relation]([AuthorId],[BookId])
	 SELECT A.[Id], B.[Id]
	 FROM [tbl_Author] AS A
	 INNER JOIN [tbl_Book] AS B ON ((LOWER(A.[FirstName]) = LOWER('Виктор') AND LOWER(A.[LastName]) = LOWER('Алёнкин'))
									AND 
									(LOWER(B.[Title]) = LOWER('Книга 10') OR LOWER(B.[Title]) = LOWER('Книга 11') OR LOWER(B.[Title]) = LOWER('Книга 12')))
	END

	IF EXISTS (SELECT [Id] FROM [dbo].[tbl_Author] WHERE LOWER([FirstName]) = LOWER('Иван') AND LOWER([LastName]) = LOWER('Цуприков'))
	BEGIN
	 INSERT INTO [dbo].[tbl_Authors_Books_Relation]([AuthorId],[BookId])
	 SELECT A.[Id], B.[Id]
	 FROM [tbl_Author] AS A
	 INNER JOIN [tbl_Book] AS B ON ((LOWER(A.[FirstName]) = LOWER('Иван') AND LOWER(A.[LastName]) = LOWER('Цуприков'))
									AND 
									(LOWER(B.[Title]) = LOWER('Книга 13') OR LOWER(B.[Title]) = LOWER('Книга 14') OR LOWER(B.[Title]) = LOWER('Книга 15')))
	END

END