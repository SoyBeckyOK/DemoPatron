using DemoPatron.DAL;
using DemoPatron.Entities;
using DemoPatron.Repository;
using System;
using System.Collections.Generic;

namespace DemoPatron.BLL
{
    public class CategoryManager
    {
        private readonly CategoryDAL DAL;
        public CategoryManager()
        {
            DAL = new CategoryDAL();
        }
        public List<Category> GetCategories()
        {
            //Logica de negocio 
            // if producto.invetario == 0 no eliminar
            // if producto.Name == NewName then no guardar
            return DAL.GetCategories();
        }
    }
}
