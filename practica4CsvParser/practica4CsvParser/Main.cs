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
				if(array.Length>0){
					Console.WriteLine("ID: "+ array[0] );
				}
				
				if(array.Length>1){
					Console.WriteLine("NOMBRE: "+ array[1] );
				}
				
				if(array.Length>2){
					Console.WriteLine("DIRECCIÓN: "+ array[2] );
				}
				
				if(array.Length>3){
					Console.WriteLine("TELÉFONO: "+ array[3] );
				}
            }

            Console.ReadKey();
        }
    }
}