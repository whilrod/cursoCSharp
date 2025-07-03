using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDeTextoANumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // .Parse()
            Console.WriteLine("Ingrese el primer valor");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado concatenado es: " + (valor1 * valor2));
            Console.WriteLine($"El resultado interpolado es: {valor1 * valor2}");
        }
    }
}
