CREATE PROCEDURE USPGetBooks
(
  @SearchExpression VARCHAR(MAX),
  @Start INT,
  @Length INT,
  @TotalFilter INT OUT
)
AS
BEGIN

	SELECT
		B.Id,
		B.Title,
		B.ReleaseDate,
		B.Rating,
		B.PageCount,
		(SELECT DISTINCT CONCAT(A.Id,'#',A.FirstName + ' ' + A.LastName, ';') 
				FROM tbl_Author AS A
				INNER JOIN tbl_Authors_Books_Relation AS ABR ON A.Id = ABR.AuthorId AND ABR.BookId = B.Id
				FOR XML PATH('')) AS Author
	INTO #Books
	FROM tbl_Authors_Books_Relation AS ABR
	INNER JOIN tbl_Book AS B ON ABR.BookId = B.Id
	WHERE B.Title LIKE '%'+ ISNULL(@SearchExpression,'') +'%'
	GROUP BY B.Id, B.Title, B.ReleaseDate, B.Rating, B.PageCount
	

	SELECT @TotalFilter = COUNT(*) FROM #Books
	
	SELECT * 
	FROM #Books
	ORDER BY #Books.Title OFFSET @Start ROWS FETCH NEXT @Length ROWS ONLY

	DROP TABLE #Books
END





