using DemoPatron.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatron.TestConsoloAppNF
{
    class Program
    {
        static void Main(string[] args)
        {
            var Alumnos = new  AlumnoManager().GetAlumnos();
            
                foreach (var alumno in Alumnos)
                {
                    Console.WriteLine($"ID: {alumno.ID_Alumno}, Nombre: { alumno.Nombre}, Apellido: { alumno.Apellido}, Direccion: {alumno.Direccion}, Telefono:  {alumno.Telefono} ");
                }
            Console.ReadLine();
        }
    }
}
