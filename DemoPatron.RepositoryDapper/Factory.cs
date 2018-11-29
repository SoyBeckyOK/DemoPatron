using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using Npgsql;

namespace DemoPatron.RepositoryDapper
{
    public class Factory : IDisposable

    {
        public System.Data.IDbConnection connection { get; }
        
            
        public Factory()
        {
            var Provider = new Helper("Provider").GetConnectionString();
            var connString = new Helper("ConnectionString").GetConnectionString();
            switch (Provider)
            {
                case "SQLSERVER":
                    connection = new SqlConnection();
                    break;
                case "POSTGRESQL":
                    connection = new NpgsqlConnection();
                    break;
                case "SQLITE":
                    connection = new SQLiteConnection();
                    break;
                case "MYSQL":
                    connection = new SQLiteConnection();
                    break;
                default:
                    break;
            }
            connection.ConnectionString = connString;
            
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
