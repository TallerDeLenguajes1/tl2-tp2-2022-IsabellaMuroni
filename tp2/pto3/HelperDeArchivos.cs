using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace pto3
{
    public static class HelperDeArchivos
    {
        static void cargarArchivo (List<Alumno> listaAlumnos, string CsvFileName)
        {
            string directorio = "Lista";

            if(!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            string csvFile = directorio + @"\" + CsvFileName;
            string line;

            try
            {
                using (StreamWriter file = File.CreateText(csvFile))
                {
                    foreach (Alumno alumno in listaAlumnos)
                    {
                        line = alumno.concatenarDatos();
                        file.WriteLine(line);
                    }
                    file.Close();
                }
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Ocurrió un error");
            }

        }
        
    }
}