using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_rownianie_kw
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = 2, B = 3, C = -2;

            Console.WriteLine("Parametry rownania:\n");
            Console.WriteLine("A = " + A + ", B = " + B + ", C = " + C + "\n");

            if (A == 0)
            {
                Console.WriteLine("A musi byc wieksze od zera.");
            }
            else
            {

                double delta = B * B - 4 * A * C;

                if (delta < 0)
                {

                    Console.WriteLine("Delta mniejsza od zera.");
                    Console.WriteLine("Dla delty mniejszej od zera nie ma rozwiazan w zbiorze liczb rzeczywistych.");

                }
                else if (delta == 0)
                {
                    double wynik = -B / (2 * A);
                    Console.WriteLine("Wynik x = "+wynik);
                }
                else
                {

                    double wynik;

                    wynik = (-B + Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine("Rozwiazanie x1 = " + wynik);
                    wynik = (-B + Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine("Rozwiazanie x2 = " + wynik);

                }
            }

        }
    }
}
