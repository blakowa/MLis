using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i++ < 20)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine("i = {0} jest nieparzysta.", i);   
            }
        }
    }
}
