using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -100; i <= 100; i++)
            {
                if (i % 4 != 0 || i % 8 == 0 || i % 10 == 0) continue;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("i = {0} jest podzielne przez 4, ale nie przez 8 i 10.", i);
            }

        }
    }
}
