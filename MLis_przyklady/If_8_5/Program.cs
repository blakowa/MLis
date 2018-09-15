using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bok kwadratu - a, promien kola r. 
            int a = 4, r = 6;

            if ((2 * a) <= (2 * r))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Kwadrat o boku rownym " + a + " mozna zmiescic w okregu o promnieniu = " + r);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Kwadrat o boku rownym " + a + " NIE DA SIE wpisac w okrag o promnieniu = " + r);
            }
            

        }
    }
}
