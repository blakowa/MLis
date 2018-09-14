using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklady_If_else
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
                    Console.WriteLine("Delata < 0.");
                    Console.WriteLine("To rownanie nie ma rozwian ");
                }
                else
                {

                    double wynik;

                    if (delta == 0)
                    {

                        wynik = -B / (2 * A);
                        Console.WriteLine("Rozwiazanie x = " + wynik);

                    }
                    else
                    {
                        wynik = (-B + Math.Sqrt(delta)) / (2 * A);
                        Console.WriteLine("Rozwiaze x1 = " + wynik);
                        wynik = (-B - Math.Sqrt(delta)) / (2 * A);
                        Console.WriteLine("Rozwiaze x2 = " + wynik);
                    }

                }
            }

        }
    }
}
