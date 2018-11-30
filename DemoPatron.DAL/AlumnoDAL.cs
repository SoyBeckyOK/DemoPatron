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

        public Alumno Insert(Alumno alumno)
        {
            var query = $"INSERT INTO T_Alumnos (ID_Alumno, Nombre, Apellido, Direccion, Telefono) VALUES ({alumno.ID_Alumno}, '{alumno.Nombre}', '{alumno.Apellido}', '{alumno.Direccion}', {alumno.Telefono});";
            return repository.Create(query, alumno);
        }

        public int Delete(int id)
        {
            var query = $"DELETE FROM T_Alumnos  WHERE ID_Alumno={id};";
            return repository.Delete(query);
        }
        public int Update(Alumno alumno, int id)
        {
            var query = $"UPDATE T_Alumnos SET ID = {alumno.ID_Alumno}, Nombre = {alumno.Nombre}, Apellido = {alumno.Apellido}, Direccion = {alumno.Direccion} , Telefono  {alumno.Telefono} WHERE {id}; ";
            return repository.Delete(query);
        }

    }
}
