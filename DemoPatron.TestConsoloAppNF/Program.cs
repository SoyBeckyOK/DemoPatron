using DemoPatron.BLL;
using DemoPatron.Entities;
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
            string op;

            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("1) Crear ");
            Console.WriteLine("2) Eliminar ");
            Console.WriteLine("3) Actualizar ");
            Console.WriteLine("4) Mostrar ");
            op = Console.ReadLine();

            switch (op)
            {
                case "1":

                    break;
                case "2":
                    Eliminar();
                    break;
                case "3":

                    break;
                case "4":
                    Mostrar();
                    break;

                default:
                    break;
            }


            Console.ReadLine();

        }


        public static void Mostrar() {
            var Alumnos = new AlumnoManager().GetAlumnos();

            foreach (var alumno in Alumnos)
            {
                Console.WriteLine($"ID: {alumno.ID_Alumno}, Nombre: { alumno.Nombre}, Apellido: { alumno.Apellido}, Direccion: {alumno.Direccion}, Telefono:  {alumno.Telefono} ");
            }
            
        }

        public static void Eliminar()
        {
            var al = new Alumno();
            int id = 0;
            Console.WriteLine("Ingrese un id a eliminar");
            Mostrar();
            
            id =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Registro Eliminado");
            var Alumnos = new AlumnoManager().Eliminar(id);
            
            Console.ReadLine();
        }
    }
}
