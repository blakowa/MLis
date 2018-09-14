using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_8_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = 1, B = 2, C = 7;
            double delta;

            if (A == 0)
            {
                Console.WriteLine("A = 0 - to nie jest równanie kwadratowe");
            }
            else 
            {
                delta = B * B - 4 * A * C;
                Console.WriteLine("Delata jest rowna = "+delta);

                if (delta < 0)
                {
                    Console.WriteLine("Rownanie nie ma rozwizania w zbiorze liczb rzeczywistych delta  < 0.");
                }
                else
                {
                    Console.WriteLine("Rownanie  ma jedno lub wiecej rozwiazan w zbiorze liczb rzeczywistych delta  => 0.");
                }

            }
        }
    }
}
