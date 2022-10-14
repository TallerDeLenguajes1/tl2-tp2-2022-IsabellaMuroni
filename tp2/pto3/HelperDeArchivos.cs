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
        public static void cargarArchivo (List<Alumno> listaAlumnos, string csvFileName)
        {
            string directorio = "Lista de Alumnos";
            if (!Directory.Exists (directorio))//Si no exixte el directorio, lo crea
            {
                Directory.CreateDirectory(directorio);
            }

            string ruta = directorio + @"\" + csvFileName;
            string line;

            try
            {
                using (StreamWriter file = File.CreateText(csvFile))
                {
                    foreach (Alumno alu in listaAlumnos)
                    {
                        line = alu.concatenarDatos(); //Se guardan datos de un alumno
                        file.WriteLine(line);//Se escribe en el archivo
                    }

                    file.Close();//Cierro archivo
                }

                Console.WriteLine ("listaalumnos" + csvFileName + "se guardó exitosamente"); 
            }
            catch (System.Exception)
            {
                Console.WriteLine("\n\n¡Hubo un error!");
                Console.WriteLine(error.Message);
            }
        }
        

        //Función para cargar archivo csv
        public static void cargarListado (List<Alumno> listaAlumnos, string fileName)
        {
            string [] content = File.ReadAllLines(fileName);
            foreach (strign line in content)
            {
                string [] delimitedContent = line.Split(';');
                int dni = Convert.ToInt32(delimitedContent[0]);
                string nombre = delimitedContent[1];
                string apellido = delimitedContent[2];
                
                Alumno newObject = new Alumno(dni, nombre, apellido);
                listaAlumnos.Add(newObject);
            }
        }
    }
}