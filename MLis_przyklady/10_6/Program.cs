using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 100; i > 0; i--)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("i = {0} jest podzielne przez 3, ale nie jest podzielne przez 2.", i);
                }
            }
            
        }
    }
}
