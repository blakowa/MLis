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
            //Petla wykona sie raz dla falszywego warunku.

            int k = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[k = {0}] Petla wykona sie raz pomimo nie spelnienia warunku k < 0", k);
            }
            while (k < 0);
        }
    }
    
}
