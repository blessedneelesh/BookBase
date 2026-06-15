using BookBase.Repository.Interface;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace BookBase.Repository.Context
{
    public class RepositoryContext: IRepositoryContext
    {
        private string _connectionString;
        private NpgsqlDataSource _dataSource;

        public RepositoryContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BookBaseDatabase")
                ?? throw new InvalidOperationException("Connection string 'BookBaseDatabase' database was not found.");

            _dataSource = new NpgsqlDataSourceBuilder(_connectionString).Build();
        }

        public IDbConnection GetDatabaseConnection()
        {
            try
            {
                return OpenConnection();
            }
            catch (PostgresException ex) when (ex.SqlState == "28P01") // SQL login failure error number
            {
               // Log.Error(ex, "Database login failed (SqlState: {SqlState}). Attempting to reload secrets and retry connection.", ex.SqlState);
                return OpenConnection();
            }
            //catch (Exception ex)
            //{
            //    if (ex is PostgresException pgEx)
            //        Log.Error(pgEx, "Unexpected database exception (SqlState: {SqlState}) while opening the connection.", pgEx.SqlState);
            //    else
            //        Log.Error(ex, "An unexpected exception occurred while opening the connection.");
            //    throw new InvalidOperationException("Failed to open a database connection.", ex);
            //}
        }

        public NpgsqlConnection OpenConnection()
        {
            var connection= new NpgsqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}
