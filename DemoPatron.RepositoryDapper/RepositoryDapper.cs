using System;
using System.Collections.Generic;
using DemoPatron.Repository;
using Dapper;
using System.Linq;
using System.Data.SqlClient;
using Npgsql;
using System.Linq.Expressions;
using Dapper.Contrib;

namespace DemoPatron.RepositoryDapper
{
    public class RepositoryDapper<T> : IRepository<T> where T : class
    {
        public T Create(string query, T t)
        {
            using (var connection = new Factory())
            {
                return connection.connection.Query(query, t).Single();
            }
        }

        public int Delete(string query)
        {
            using (var connection = new Factory())
            {
                return connection.connection.QuerySingle(query);
                //return connection.connection.Query(query).Single();
                
            }
            
        }
        

        public IEnumerable<T> GetAll(string query)
        {
            using (var connection = new Factory())
            {
                return connection.connection.Query<T>(query).ToList();
            }
        }

        public int Update(string query, int id)
        {
            using (var connection = new Factory())
            {
                return connection.connection.Query(query, id).Single();
            }
        }
    }
}
