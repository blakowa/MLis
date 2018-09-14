using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_8_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 7, b = 5;
            int reszta = a % b;

            Console.WriteLine("Zmienna a = "+a+" zmienna b = "+b);

            if (reszta != 0)
            {

                Console.WriteLine("Reszta z dzielnia wynosi " + reszta);

            }
            else
            {

                Console.WriteLine("Reszta z dzielnia "+a+"przez"+b+" wynosi zero.");

            }

        }
    }
}
