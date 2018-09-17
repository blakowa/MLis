using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petla_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.WriteLine("[i = {0}] Petle w C#", i);
            }
            while (i++ < 9);

            int j = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("[j = {0}] Petle w C#", j);
                j++;
            }
            while (j  < 10);
        }
    }
    
}
