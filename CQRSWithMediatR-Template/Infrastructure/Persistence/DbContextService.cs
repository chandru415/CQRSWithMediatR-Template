using Application.Common.Interfaces;
using System;
using System.Data.SqlClient;

namespace Infrastructure.Persistence
{
    internal class DbContextService : IDbContextService
    {
        public SqlConnection CreateDbConnection()
        {
            throw new NotImplementedException();
        }

        public string DbContext()
        {
            throw new NotImplementedException();
        }
    }
}
