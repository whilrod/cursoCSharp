using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * suma + ++ (suma 1 automaticamente)
             * resta - -- (resta 1 automaticamente)
             * multiplicación *
             * división / solo parte entera por defecto,
             * para incluir decimales agregar ".0" ej:5.0 /2.0 = 3.5
             * 
             * módulo o resto %
             */
            Console.WriteLine(5 + 2);
            Console.WriteLine(5 - 2);
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5.0 / 2.0);
            Console.WriteLine(5 % 2);

            int edad = 35;
            Console.WriteLine($"tu edad es {edad} años");
            Console.WriteLine("tu edad es " + (++edad) +" años"); // primero actualiza variable y luejo ejecuta la funcion
            Console.WriteLine(edad--); // primero ejecuta la funcion y luego actualiza variable
        }
    }
}
