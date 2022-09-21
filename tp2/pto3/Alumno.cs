using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pto3
{
    public class Alumno
    {
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int Dni { get; set; }
        public int Curso { get; set; }

            //Constructor
        public Alumno () {}

        public Alumno (int id, string nombre, string apellido, int dni, int curso)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.dni = Dni;
            this.curso = Curso;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public int Dni1 { get => Dni; set => Dni = value; }
        public int Curso1 { get => Curso; set => Curso = value; }


        public string concatenarDatos()
        {
            return Id1 + ";" + Apellido1 + ";" + Nombre1;
        }
    }
    
}

