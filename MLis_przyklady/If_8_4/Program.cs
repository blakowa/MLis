using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 5, h = 4, w = 5;
            int ptkx = 7, ptky = 4;

            if ((ptkx > x  &  ptkx < w + x) & (ptky < y & ptky > y - h))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Punkt o wspolrzencych x,y rownych = " +  ptkx + ',' +  ptky);
                Console.WriteLine("Zawiera sie w prostokoncie o wspolrzenych lewgo gornego rogu x= " + x + " y = " + y + "wysokoœci = " + h + ", szerokosci = " + w);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Punkt o wspolrzencych x,y rownych = " + ptkx + ',' + ptky);
                Console.WriteLine("NIE zawiera sie w prostokoncie o wspolrzenych lewgo gornego rogu x= " + x + " y = " + y + "wysokoœci = " + h + ", szerokosci = " + w);;
            }


        }
    }
}
