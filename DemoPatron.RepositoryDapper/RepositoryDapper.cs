using System;
using System.Collections.Generic;
using DemoPatron.Repository;
using Dapper;
using System.Linq;
using System.Data.SqlClient;
using Npgsql;
using System.Linq.Expressions;

namespace DemoPatron.RepositoryDapper
{
    public class RepositoryDapper<T> : IRepository<T> where T : class
    {
        public T Create(T t)
        {
            throw new NotImplementedException();
        }

        public int Delete(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(string query)
        {
            using (var connection = new Factory())
            {
                return connection.connection.Query<T>(query).ToList();
            }
        }

        public int Update(T T)
        {
            throw new NotImplementedException();
        }
    }
}
