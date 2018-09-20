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
                if (i % 3 == 0 & i % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("i = {0} jest podzielne przez 3, ale nie jest podzielne przez 2.", i);
                }
            }

            int j = 100;
            while (j > 0)
            {
                if (j % 3 == 0 & j % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("j = {0} jest podzielne przez 3, ale nie jest podzielne przez 2.", j);
                }
                j--;
            }

            int k = 100;
            do
            {
                if (k % 3 == 0 & k % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("k = {0} jest podzielne przez 3, ale nie jest podzielne przez 2.", k);
                }
            }
            while (k-- > 0);
        }
    }
}
