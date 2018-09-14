using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x1 = 6,  y1 = 5, x2 = 8,  y2 = 5;

            if (x1 == x2 && y1 == y2) 
            {
                Console.WriteLine("To nie jest prosta tylko punkt");
            }
            else if ((x1 == x2) && (y1 != y2))
            {
                Console.WriteLine("Prosta jest rownolegla do osi Y.");
            }
            else if ((y1 == y2) && (x1 != x2))
            {
                Console.WriteLine("Prosta jest rownolegla do osi X");
            }
            else
            {
                Console.WriteLine("Prosta nie jest rownolegla do zadnej z osi.");
            }
        }
    }
}
