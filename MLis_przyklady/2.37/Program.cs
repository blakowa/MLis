using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._37
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("i = {0}; j = {1}", i, j);
                }
            }

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    if (k == 2) break;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("k = {0}; l = {1}", k, l);
                }
            }
        }
    }
}
