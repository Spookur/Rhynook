using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoForsAndTenYearsAgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year would you like to count back from? ");

            int year = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " years ago would be " + (year - i));
            }

            Console.WriteLine("\nI can count backwards using a different way too...");

            for (int i = year; i >= year - 10; i--)
            {
                Console.WriteLine((year - i) + " years ago would be " + i);
            }

            Console.ReadLine();
        }
    }
}
