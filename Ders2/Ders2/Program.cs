using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mustafa Koca | Kalp";

            int boyut = 6;
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j <= 4 * boyut; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(i - boyut, 2) + Math.Pow(j - boyut, 2));
                    double dist1 = Math.Sqrt(Math.Pow(i - boyut, 2) + Math.Pow(j - 3 * boyut, 2));

                    if (dist < boyut + 0.5 || dist1 < boyut + 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                 Console.WriteLine();
            }
            for (int m = 0; m < 2 * boyut; m++)
            {
                for (int k = 0; k < m; k++)
                {
                    Console.Write(" ");
                }
                for (int e = 0; e < 4 * boyut + 1 - 2 * m; e++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();
            }



            Console.ReadLine();

        }
    }
}
