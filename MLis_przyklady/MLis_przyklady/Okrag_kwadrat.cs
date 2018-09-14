using System;


public class Okrag_kwadrat
{
    
    public static void Main()
    {
        int dl = 7;
        double r = 9;
        double przekontna = dl * Math.Sqrt(2);

        if (przekontna <= 2 * r)
        {
            Console.WriteLine("Kwadrat o boku " + dl + " i przekontnej " + przekontna + " zmiesci sie w okregu o promieniu = " + r);
        }
        else
        {
            Console.WriteLine("Kwadrat o boku " + dl + " i przekontnej " + przekontna + " NIE zmiesci sie w okregu o promieniu = " + r);
        }

    }
}
