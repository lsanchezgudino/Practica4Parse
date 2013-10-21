using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            parser parser = new parser();
            parser.leerArchivo();
            parser.verifyFileType();
            List<string[]> myFile = parser.getFileContent();

            foreach(string[] array in myFile)
            {

                Console.WriteLine("id: " + array[0] + "\nNombre: " + array[1] + "\nDirección: " + array[2] + "\nTeléfono: " + array[3]);
            
            }

            Console.ReadKey();
        }
    }
}