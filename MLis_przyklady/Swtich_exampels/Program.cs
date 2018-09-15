using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swtich_exampels
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 1;
            etykieta:
            switch (liczba)
            {
                case 1 :
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("liczba  = 1");
                    goto default;
                case 2 :
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("liczba  = 2");
                    goto default;
                case 3:
                    
                    liczba--;
                    goto case 4;
                case 4 :
                    goto etykieta2;
                default :
                    liczba++;
                    goto etykieta;
            }
            etykieta2:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Blok switch zostal zakonczony: ");
            Console.WriteLine("liczba = {0} " + liczba);

        }
    }
}
