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
            Console.WriteLine(numero);

            // Conversion Explicita
            int valor = (int)4.5;
            Console.WriteLine(valor);
            Console.WriteLine(valor);
        }
    }
}
