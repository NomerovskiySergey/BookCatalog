IF NOT EXISTS (SELECT [Id] FROM [dbo].[tbl_Autors] WHERE [Id] = 1)
BEGIN
        INSERT INTO [dbo].[tbl_Autors]([FirstName],[LastName])
        VALUES('Эмануил', 'Бланк')
END

IF NOT EXISTS (SELECT [Id] FROM [dbo].[tbl_Autors] WHERE [Id] = 2)
BEGIN
        INSERT INTO [dbo].[tbl_Autors]([FirstName],[LastName])
        VALUES('Алекс', 'Шуваевский')
END

IF NOT EXISTS (SELECT [Id] FROM [dbo].[tbl_Autors] WHERE [Id] = 3)
BEGIN
        INSERT INTO [dbo].[tbl_Autors]([FirstName],[LastName])
        VALUES('Евгения', 'Серенко')
END

IF NOT EXISTS (SELECT [Id] FROM [dbo].[tbl_Autors] WHERE [Id] = 4)
BEGIN
        INSERT INTO [dbo].[tbl_Autors]([FirstName],[LastName])
        VALUES('Иван', 'Цуприков')
END

IF NOT EXISTS (SELECT [Id] FROM [dbo].[tbl_Autors] WHERE [Id] = 5)
BEGIN
        INSERT INTO [dbo].[tbl_Autors]([FirstName],[LastName])
        VALUES('Виктор', 'Алёнкин')
END
