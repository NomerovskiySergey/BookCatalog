using System.Data;
using System.Data.SqlClient;
using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;
using Dapper;

namespace BookCatalog.DAL.Repositories
{
    public class AuthorRepository : DapperBaseRepository<int, AuthorEM>, IAuthorRepository
    {
        #region Constructors
        public AuthorRepository(IRootContext context) : base(context) { }
        #endregion

        public DisplayAuthorEM Get(int id)
        {
            var query = @"SELECT A.FirstName, 
	                             A.LastName, 
	                             COUNT(ABR.AuthorId) AS BookCount
                                 FROM tbl_Author AS A
                                 JOIN tbl_Authors_Books_Relation AS ABR ON A.Id = ABR.AuthorId
                                 WHERE A.Id = @AuthorId
                                 GROUP BY A.FirstName, A.LastName";

            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                var queryParams = new DynamicParameters();
                queryParams.Add("@AuthorId", id, DbType.Int32, ParameterDirection.Input);

                return connection.QueryFirstOrDefault<DisplayAuthorEM>(query, queryParams);
            }
        }
    }
}
