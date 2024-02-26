//USO BÀSICO DE C# para NET
using System;

namespace Curso_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de datos
            int year = 10;
            Console.WriteLine("Hello, World! prueba " + year);

            string palabra = "gato";
            double numDec = 2.5;
            bool valor = false; //tipo de dato
            Boolean valor2 = true; //estructura
            Console.WriteLine("Hello, World! prueba {0} {1} {2}", palabra,valor,valor2);

            Console.ReadLine();
        }
    }
}

