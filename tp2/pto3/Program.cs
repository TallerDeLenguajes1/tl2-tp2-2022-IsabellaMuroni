using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLog;


namespace pto3 {

    class Program
    {
        static void Main (string [] args) 
        {
            NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger(); //para loggear reportes
           
            //Creo listas de alumnos según cursos
            List<Alumno> Atletismo = new List<Alumno>();
            List<Alumno> Voley = new List<Alumno>();
            List<Alumno> Futbol = new List<Alumno>();

            //Creo nuevo objeto
            Alumno nuevoAlumno = new Alumno();
            
            

            Console.WriteLine("Instituto de Educación Física");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            nuevoAlumno.nombre = nombre;
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            nuevoAlumno.apellido = apellido;

            Console.WriteLine(nuevoAlumno.concatenarDatos());

        }
        
    }

}