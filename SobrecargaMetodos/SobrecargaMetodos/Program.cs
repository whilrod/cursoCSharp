using System;
using System.Data;

namespace SobrecargaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(suma(2,3));
            Console.WriteLine(suma(2, 3, 5.9));
        }
        //mismo nombre pero diferente tipo de parametros o diferente cantidad de parametros

        static int suma(int numero1, int numero2) => numero1 + numero2;

        static int suma(int numero1, int numero2, int numero3) => numero1 + numero2 + numero3;

        static double suma(int numero1, int numero2, double numero3 = 0 ) => numero1+ numero3;
    }
}
