using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ismodulo;
            int a = 36, b = 6;

            ismodulo = (a % b != 0) ? false : true;
            Console.WriteLine("Reszta z dzielnie isntnieje jeżeli FALSE: " + ismodulo);

        }
    }
}

