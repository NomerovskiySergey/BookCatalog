IF NOT EXISTS (SELECT 1 FROM [tbl_Author])
BEGIN

INSERT INTO [dbo].[tbl_Author] ([FirstName], [LastName])
	VALUES  ('Эмануил', 'Бланк'),
			('Алекс', 'Шуваевский'),
			('Евгения', 'Серенко'),
			('Иван', 'Цуприков'),
			('Виктор', 'Алёнкин')

END