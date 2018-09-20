using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("i = {0} jest parzyste.", i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("i = {0} jest nieparzyste.", i);
                }
            }

            int j = 1;

            while (j <= 20)
            {
                if (j % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("j = {0} jest parzyste.", j);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("j = {0} jest nieparzyste.", j);
                }
                j++;
            }

            int k = 1;

            do
            {
                if (k % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("k = {0} jest parzyste.", k);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("k = {0} jest nieparzyste.", k);
                }
                
            }
            while (k++ < 20);
        }
    }
}
