using System;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            long cF = 0, pN = 0, sN = 1;
            long fibonacci = 0;
            long modulo = 0;
            bool esprimo = true;

            Console.WriteLine("Digite la cantidad de elementos que desea: ");
            cF = int.Parse(Console.ReadLine());

            for (int i = 0; i < cF; i++)
            {
                fibonacci = pN + sN;
                sN = pN;
                pN = fibonacci;
                modulo = fibonacci % 2;
                if (modulo == 0)
                {
                    Console.Write(i + 1 + " " + fibonacci + "; Es par");
                }
                else
                {
                    Console.Write(i + 1 + " " + fibonacci + "; Es impar");
                }
                for (int h = 2; h < fibonacci; h++)
                {
                    if (modulo == 0)
                    {
                        esprimo = false;
                    }
                }
                if (esprimo)
                {
                    Console.Write(", es primo");
                }
                else
                {
                    Console.Write(", no es primo");
                }
                if (fibonacci <= 9)
                {
                    Console.Write(", " + Convert.ToString(fibonacci % 10));
                    fibonacci = fibonacci / 10;
                }
                else
                {
                    while (fibonacci > 0)
                    {
                        Console.Write(", " + Convert.ToString(fibonacci % 10));
                        fibonacci = fibonacci / 10;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
