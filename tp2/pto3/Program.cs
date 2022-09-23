using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace pto3 {

    class Program
    {
        static void Main (string [] args) 
        {
            //Creo listas de alumnos según cursos
            List<Alumno> Atletismo = new List<Alumno>();
            List<Alumno> Voley = new List<Alumno>();
            List<Alumno> Futbol = new List<Alumno>();

            //Creo nuevo objeto
            Alumno nuevoAlumno = new Alumno();
            
            nuevoAlumno.nombre = nombre;
            nuevoAlumno.apellido = apellido;

            Console.WriteLine("Instituto de Educación Física");
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine(nuevoAlumno.Nombre1);

        }
        
    }

}