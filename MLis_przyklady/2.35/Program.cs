using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._35
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("i = {0} Petle w C#", i);
                if (i == 9)
                {
                    break;
                }
            }

            int j = 0;
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("j = {0} Petle w C#", j);
                if (j++ >= 9)
                {
                    break;
                }
            }
        }
    }
}
