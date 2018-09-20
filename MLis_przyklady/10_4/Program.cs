using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("i = {0} Petle w C#", i);
                i++;
            }
            while (i <= 9);
        }
    }
}
