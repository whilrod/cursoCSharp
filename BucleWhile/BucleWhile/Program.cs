using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciar bucle?");
            string respuesta = Console.ReadLine();

            while (respuesta!= "no")
            {
                Console.WriteLine("Ejecutando el bucle...");
                Console.WriteLine("Desea continuar?");
                respuesta = Console.ReadLine();
            }

            Console.WriteLine("Saliendo del bucle");

            do{
                Console.WriteLine("Ejecutando el bucle...");
                Console.WriteLine("Desea continuar?");
                respuesta = Console.ReadLine();
            } while (respuesta != "no");

        }
    }
}
