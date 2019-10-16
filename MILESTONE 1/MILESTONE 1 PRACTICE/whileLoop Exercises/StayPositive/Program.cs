using System;

namespace StayPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int pick;

            Console.WriteLine("Pick a number! I will count down from it. :)");

            pick = Convert.ToInt32(Console.ReadLine());


            while (pick > -1)
            {
                Console.Write("Me llamo Willy K ");

                Console.WriteLine(pick);

                pick--;
            }
        }
            
    }
}
