using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad_petli_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int  wartosc in tab)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(wartosc);
            }
        }
    }
}
