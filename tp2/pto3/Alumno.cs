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

    }
}