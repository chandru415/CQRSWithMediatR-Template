using Application.Common.Interfaces;
using Infrastructure.Common;
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
            return ConfigurationConstants.DBConnectionString;
        }
    }
}
