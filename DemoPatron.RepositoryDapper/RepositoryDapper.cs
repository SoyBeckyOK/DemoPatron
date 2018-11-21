using System;
using System.Collections.Generic;
using DemoPatron.Repository;
using Dapper;
using System.Linq;
using System.Data.SqlClient;

namespace DemoPatron.RepositoryDapper
{
    public class RepositoryDapper<T> : IRepository<T> where T : class
    {
        private readonly string connString;

        public RepositoryDapper(string connString)
        {
            this.connString = connString;
        }
        //Daper trabaja con todo objeto que sea idbconexion y facilita el proceso
        
        public IEnumerable<T> GetAll(string query)
        {
            //ADO.NET para trabajar con acceso a datos 
            using (var connection = new SqlConnection(connString))
            {
                // lista enumerable
                return connection.Query<T>(query).ToList();
            }
        }

        public int Insert(string query, T data)
        {
            throw new NotImplementedException();
        }

        public int Update(string query, T data)
        {
            throw new NotImplementedException();
        }
    }
}
