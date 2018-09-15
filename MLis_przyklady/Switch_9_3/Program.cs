using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 5;
            int oper;

            oper = (liczba < 0) ? -liczba : liczba;
            Console.Write("Wartość bezwzględna zmiennej liczba to: " + oper);
            
        }
    }
}
