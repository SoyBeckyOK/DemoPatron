using DemoPatron.Entities;
using DemoPatron.Repository;
using DemoPatron.RepositoryDapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoPatron.DAL
{
    public class CategoryDAL
    {
        private readonly string cnnString;
        private readonly IRepository<Category> repository;

        public CategoryDAL()
        {
            var Helper = new Helper("DefaultSQL");
            cnnString = Helper.GetConnectionString();
            repository = new RepositoryDapper<Category>(cnnString);
            

        }
        public List<Category> GetCategories()
        {
            //Transaccione en sql
            var query = "SELECT * FROM" +
                "" +
                "T_Categories";
            return repository.GetAll(query).ToList(); //test

        }
    }
}
