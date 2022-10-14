using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace pto3
{
    public static class HelperDeArchivos
    {
        public static void cargarArchivo (List<Alumno> listaAlumnos, string csvFileName)
        {
            NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

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
            catch (Exception ex)
            {
                Console.WriteLine("\n\n¡Hubo un error!");
                Console.WriteLine(ex.Message);
                logger.Warn(ex);
                logger.Error(ex);
                logger.Fatal(ex);
            }
        }
        

        //Función para cargar archivo csv
        public static void cargarListado (List<Alumno> listaAlumnos, string fileName)
        {
            string [] content = File.ReadAllLines(fileName);
            foreach (string line in content)
            {
                string [] delimitedContent = line.Split(';');
                int dni = Convert.ToInt32(delimitedContent[0]);
                string nombre = delimitedContent[1];
                string apellido = delimitedContent[2];
                
                Alumno newObject = new Alumno(dni, nombre, apellido);
                listaAlumnos.Add(newObject);
            }
        }

        public static void leerCsv (string ruta)
        {
            //StreamReader archivo = new StreamRead (ruta);
            FileStream archivoNuevo = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader archivo = new StreamReader (archivoNuevo);

            string separador = ",";
            string linea;
            archivo.ReadLine();//Si el archivo no tiene encabezado se borra

            while ((linea = archivo.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);
                string nombre = fila[0];
                int telefono = Convert.ToInt32(fila[1]);
            }

        }

        /*
        public static void limpiarCSV(string ruta)
        {
            File.Delete(ruta);
            FileStream Fstream = new FileStream(ruta, FileMode.OpenOrCreate);
            using (StreamWriter StreamW = new StreamWriter(Fstream))
            {
                StreamW.WriteLine("ID,Apellido,Nombre,DNI");
            }
            Fstream.Close();
        }
        */
    }
}