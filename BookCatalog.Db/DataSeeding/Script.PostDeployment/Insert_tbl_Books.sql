﻿IF NOT EXISTS (SELECT 1 FROM [dbo].[tbl_Book])
BEGIN
        INSERT INTO [dbo].[tbl_Book]([Title],[ReleaseDate],[Rating],[PageCount])
        VALUES('Книга 1', '2017-12-12', 2, 120),
			  ('Книга 2', '2017-12-12', 2, 120),
			  ('Книга 3', '2017-12-12', 2, 120),
			  ('Книга 4', '2017-12-12', 2, 120),
			  ('Книга 5', '2017-12-12', 2, 120),
			  ('Книга 6', '2017-12-12', 2, 120),
			  ('Книга 7', '2017-12-12', 2, 120),
			  ('Книга 8', '2017-12-12', 2, 120),
			  ('Книга 9', '2017-12-12', 2, 120),
			  ('Книга 10', '2017-12-12', 2, 120),
			  ('Книга 11', '2017-12-12', 2, 120),
			  ('Книга 12', '2017-12-12', 2, 120),
			  ('Книга 13', '2017-12-12', 2, 120),
			  ('Книга 14', '2017-12-12', 2, 120),
			  ('Книга 15', '2017-12-12', 2, 120)
END