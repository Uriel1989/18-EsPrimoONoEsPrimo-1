using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18_EsPrimoONoEsPrimo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a;
            a = 0;

            Console.WriteLine("Ingrese un numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= 100; i++)
            {

                if (i % a == 0)
                {
                    Console.WriteLine("Los numeros que no son primos son: " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
