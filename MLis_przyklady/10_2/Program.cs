using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[i = {0}] Petle w C#.", i);
                i++;
            }

            int j = -1;

            while (j++ < 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[j = {0}] Petle w C#.", j);
                
            }
        }
    }
}
