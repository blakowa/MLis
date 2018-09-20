using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i  > 0; i --)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("j = {0};  ", j);
                }
                Console.WriteLine("\n");
            }

            int k = 20;
            while (k > 0)
            {
                int l = k;
                while (l > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("l = {0};  ", l);
                    l--;
                }
                Console.WriteLine("\n");
                k--;
            }
        }
    }
}
