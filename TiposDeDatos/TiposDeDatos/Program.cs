using System;


namespace TiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Por valor
            //** Primitivos
            // Entero de 32 bits
            int numerosEnteros = 100;
            Console.WriteLine("int: " + numerosEnteros);

            // Entero largo de 64 bits
            long numerosEnterosLargos = 10000000000L;  // nota la L al final
            Console.WriteLine("long: " + numerosEnterosLargos);

            // Número decimal de 32 bits (precisión simple)
            float numerosDecimales = 3.14f;  // nota la f al final
            Console.WriteLine("float: " + numerosDecimales);

            // Número decimal de 64 bits (doble precisión)
            double numerosDecimalesLargos = 3.14159265359;
            Console.WriteLine("double: " + numerosDecimalesLargos);

            // Número decimal de 128 bits (alta precisión, útil para finanzas)
            decimal numerosDecimales128Bits = 79228162514264337593543950335m;  // nota la m al final
            Console.WriteLine("decimal: " + numerosDecimales128Bits);

            // UTF-16: cada char representa un carácter Unicode de 16 bits
            char unCaracter = 'A';  // también puedes usar '\u0041'
            Console.WriteLine("char: " + unCaracter);

            // Booleano: verdadero o falso
            bool variableBooleana = true;
            Console.WriteLine("bool: " + variableBooleana);

            //* Por referencia
            string variableTexto;
            variableTexto = "Un texto";
            Console.WriteLine("string: " + variableTexto);

            const string TEXTONOMODIFICABLE = "Cualquier Valor";
            const int NUMERONOMODIFICABLE = 14;

            Console.WriteLine("Constante string: " + TEXTONOMODIFICABLE);
            Console.WriteLine("Constante int: " + NUMERONOMODIFICABLE);

            //**** declaracion implicita
            var edad = 18;
            var nombre = "juan";

            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Nombre: " + nombre);

            //** conversión implicita
            double numero = 10;
            Console.WriteLine("Conversión implicita de double a int" + numero);

            //**conversion explicita
            int valor = (int)10.8;
            Console.WriteLine("Conversión implicita de int a float" + valor);
        }
    }
}
