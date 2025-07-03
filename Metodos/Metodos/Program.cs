using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjunto de instrucciones con un nombre que las identificas
            //Realizan tareas hasta que sean llamados
            /*tipo devuelto nombreMetodo(parametros)
             * {
             * 
             *      cuerpo del metodo
             *      
             * }
            */

            Console.WriteLine(sumaValores()); // 30
            Console.WriteLine(SumaValoresConParametros(2, 3));
            MetodoSinRetorno(4,9);
        }

        static int sumaValores()
        {
            int valor1 = 10;
            int valor2 = 20;
            int resultado = valor1 + valor2;
            return resultado;
        }

        static int SumaValoresConParametros(int val1, int val2)
        {
            int resultado = val1 + val2;
            return resultado;
        }

        static void MetodoSinRetorno(int valor1, int valor2) // palabra void
        {
            int resultado = valor1 + valor2;
            Console.WriteLine(resultado);
        }
    }
}
