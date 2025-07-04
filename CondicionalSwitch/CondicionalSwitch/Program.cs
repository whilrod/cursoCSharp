using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elegir comida: (ceviche, tacos o paella): ");
            string comida = Console.ReadLine();
            switch (comida)
            {
                case "ceviche":
                    Console.WriteLine("Comida Peruana");
                    break;
                case "tacos":
                    Console.WriteLine("Comida Mexicana");
                    break;
                case "paella":
                    Console.WriteLine("Comida Española");
                    break;
                default:
                    Console.WriteLine("Comida no especificada");
                    break;
            }
        }
    }
}
