using System.Data.SqlClient;

namespace Application.Common.Interfaces
{
    public interface IDbContextService
    {
        /** He we can return connection string */
        string DbContext();
        /** He we can return type of connection
         * this will follow the desire Db connection
         * we wish to establish */
        SqlConnection CreateDbConnection();
    }
}
