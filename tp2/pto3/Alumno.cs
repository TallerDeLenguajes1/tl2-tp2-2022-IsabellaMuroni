using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pto3
{
    public class Alumno
    {
        private int Id;
        private string Nombre;
        private string Apellido;
        private int Dni;
        private int Curso;

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public int curso { get; set; }

        //Constructor
        public Alumno () { }

        public Alumno (int id, string nombre, string apellido, int dni, int curso)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Curso = curso;
        }

        public string concatenarDatos()
        {
            return id + ";" + apellido + ";" + nombre;
        }

        /*
        public void listar_info_pedido(){
            Console.WriteLine("DATOS PEDIDO");
            Console.WriteLine("Numero de pedido: {0}",IDpedido);
            Console.WriteLine("Observaciones: {0}",detalle);
            Console.WriteLine("Estado entrega: {0}",Enum.GetName(typeof(Estados),estadoPedido));
            Console.WriteLine();
            Console.WriteLine("DATOS CLIENTE");
            cliente!.listar_info_cliente();
            Console.WriteLine();
        }
        */
    }
    
}

