using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_warinkowy
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 10;
            int liczba2;

            liczba2 = (liczba < 0) ? -1 : 1;
            Console.WriteLine(liczba2);
        }
    }
}
