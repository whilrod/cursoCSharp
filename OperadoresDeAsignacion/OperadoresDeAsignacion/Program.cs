using System;
namespace OperadoresDeAsignacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * operadores de asignacion
             * =
             * +=
             * -=
             * *=
             * /=
             * %=
             */
            byte numero = 30;
            Console.WriteLine(numero);

            numero = Convert.ToByte(numero + 10);
            Console.WriteLine(numero);

            numero += 10;
            Console.WriteLine("+= " + numero);

            numero -= 10;
            Console.WriteLine("-= " + numero);

            numero *= 2;
            Console.WriteLine("*= " + numero);

            numero /= 3;
            Console.WriteLine("/= " + numero);

            numero %= 3;
            Console.WriteLine("%= " + numero);

            AsignacionMultiple();
        }

        public static void AsignacionMultiple()
        {
            int numero1;
            int numero2;
            int numero3;

            numero1 = numero2 = numero3 = 35;

            Console.WriteLine("numero1: " + numero1);
            Console.WriteLine("numero2: " + numero2);
            Console.WriteLine("numero3: " + numero3);
        }
    }
}
