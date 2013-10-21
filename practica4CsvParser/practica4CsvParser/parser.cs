using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4CsvParser
{
    class parser
    {
        private string @rutaDeArchivo;


        public List<string[]> getFileContent() 
        {
            List<string[]> csvArray = new List<string[]>();
            string line;
            string[] row;

            StreamReader readFile = new StreamReader(this.rutaDeArchivo);
            while ((line = readFile.ReadLine()) != null)
            {
                row = line.Split(',');
                csvArray.Add(row);
            }

            return csvArray;
        }

        public void verifyFileType()
        {

            if(verifyPath())
                if (Path.GetExtension(this.rutaDeArchivo) == ".csv")
                    Console.WriteLine("Tu archivo si es CSV");
                else
                    Console.WriteLine("Tu archivo no es CSV es " + Path.GetExtension(this.rutaDeArchivo) );
        }


        private Boolean verifyPath()
        {
            Boolean fileExist;
            if(File.Exists(this.rutaDeArchivo))
                fileExist = true;
            else
                fileExist = false;

            return fileExist;
        }

        public void leerArchivo()
        {
            Console.WriteLine("Por favor ingrese la ruta del archivo del cual desea obtener la información:");
            this.rutaDeArchivo = Console.ReadLine();
        }

    }
}