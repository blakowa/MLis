using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = -10;
            //int liczba2;

            //liczba2 = (liczba < 0) ? -1 : 1;
            //Console.WriteLine(liczba2);

            if (liczba < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
