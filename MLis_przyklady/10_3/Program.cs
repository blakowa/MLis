using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 21)
            {
                if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("i = {0} jest podzielne przez 3.", i);
                }
                i++;
            }
        }
    }
}
