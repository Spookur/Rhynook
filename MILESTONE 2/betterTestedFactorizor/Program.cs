using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betterTestedFactorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow flow = new Workflow();
            flow.Run();
            Console.WriteLine("Enter a number!"); // prompt user to enter number
            int input = Int32.Parse(Console.ReadLine()); // need to convert string to integer

            int sum = 0; // set sum to zero

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0) // input divided by all the possible numbers up until the given input. remainder of 0, 
                {
                    Console.WriteLine($"{i} is a factor of {input}"); // prints the factors (i) and the entered number (input)
                    sum += i; // adds up all of the factors
                }


            }

            Console.WriteLine("Press any key to find the sum of the number you entered.");
            

            Console.ReadLine();

            Console.WriteLine($"The sum of the factors of {input} is {sum}");

            Console.ReadLine();

           
        }
    }
}
