using DemoPatron.DAL;
using DemoPatron.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatron.BLL
{
   public class AlumnoManager
    {
        private readonly AlumnoDAL DAL;
        public AlumnoManager()
        {
            DAL = new AlumnoDAL();
        }
        public List<Alumno> GetAlumnos()
        {
            //Logica de negocio 
            // if producto.invetario == 0 no eliminar
            // if producto.Name == NewName then no guardar
            return DAL.GetAlumnos();
        }

        public int Eliminar(int id)
        {
            return DAL.Eliminar();
        }
    }
}
