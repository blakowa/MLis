using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;

            switch (number)
            {
                case 1:
                case 4:
                case 8:
                    Console.WriteLine("Liczba nazlezy do zbioru 1, 4, 8. Liczba = " + number);
                    break;
                case 2:
                case 3:
                case 7:
                    Console.WriteLine("Liczba nazlezy do zbioru 2, 3, 7. Liczba = " + number);
                    break;
                default:
                    Console.WriteLine("Liczba NIE nazlezy do zbioru 1, 4, 8 i zbioru 2, 3, 7. Liczba = " + number);
                    break;
            }
        }
    }
}
