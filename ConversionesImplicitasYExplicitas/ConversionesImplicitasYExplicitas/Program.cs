using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionesImplicitasYExplicitas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversion Implicita
            double numero = 10;
            Console.WriteLine(numero); // 10

            // Conversion Explicita
            int valor = (int)4.5;
            Console.WriteLine(valor); // 4 se pierde la parte decimal
            
        }
    }
}
