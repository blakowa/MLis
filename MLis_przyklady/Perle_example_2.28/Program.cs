using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perle_example_2._28
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10;)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[i = {0}] Petle w C#", i);
                i++;
            }

            int j = 0;
            for (; j < 10;)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[j = {0}] Petle w C#", j);
                j++;
            }

            int k = 0;
            for (; k++ < 10; ) //Tu najpierw sprwdza czy k jest mniejsze od 10 a potem dopiero dodaje do k +1.
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[k = {0}] Petle w C#", k);
            }
        }
    }
}
