using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 3 != 0 & i % 4 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("i = {0} jest nie podzielne przez 3 i 4.", i);
                }
            }

            for (int j = 100; j > 0; j--)
            {

                if (j % 3 == 0 || j % 4 == 0) continue;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("j= {0} jest nie podzielne przez 3 i 4.", j);
            }
        }
    }
}
