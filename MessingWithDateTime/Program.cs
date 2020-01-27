using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessingWithDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("11/3/2019 1:48:00 AM");

            DayOfWeek day = d1.DayOfWeek;

            switch (day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend. Alright, party!");
                    break;
                default:
                    Console.WriteLine("It's a weekday.");
                    break;
                    
            }

            Console.ReadLine();
        }
    }
}
