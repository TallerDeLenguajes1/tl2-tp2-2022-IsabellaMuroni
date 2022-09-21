using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace pto3 {

    class Program
    {
        static void Main (string [] args) 
        {
            //Creo nuevo objeto
            Alumno nuevoAlumno = new Alumno();

            Console.WriteLine("Instituto de Educación Física");
            Console.WriteLine("Nombre: ");
            nuevoAlumno.Nombre1 = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            nuevoAlumno.Apellido1 = Console.ReadLine();

            Console.WriteLine(nuevoAlumno.Nombre1);

        }
        
    }

}