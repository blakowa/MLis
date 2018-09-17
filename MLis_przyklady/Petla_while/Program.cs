using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petla_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("[i = {0}] Petle w C#", i);
                i++;
            }

            int j = 0;

            while (j++ < 10)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[j = {0}] Petle w C#", j);
            }
        }
    }
}
