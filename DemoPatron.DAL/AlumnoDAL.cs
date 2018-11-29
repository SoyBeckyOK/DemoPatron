using DemoPatron.Entities;
using DemoPatron.Repository;
using DemoPatron.RepositoryDapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPatron.DAL
{
    public class AlumnoDAL
    {
        private readonly IRepository<Alumno> repository;

        public AlumnoDAL()
        {
            repository = new RepositoryDapper<Alumno>();
        }

        public List<Alumno> GetAlumnos()
        {
            var query = "SELECT * FROM T_Alumnos";
            return repository.GetAll(query).ToList();
        }

    }
}
