using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeInformation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter: \"create\" to create dates... ");
            Console.WriteLine("Enter: \"add\" to add dates...");
            Console.WriteLine("Enter: \"subtract\" to subtract dates... ");
            Console.WriteLine("Enter: \"manipulate\" to manipulate data values... ");
            Console.WriteLine("Enter: \"get date\" to get a pre set date...");

            string input = Console.ReadLine();

            if (input == "create")
            {
                CreateDateTimeObjects();
            }

            if (input == "get date")
            {
                GettingDayOfYear();
            }

            if (input == "subtract")
            {
                DifferenceOfDates();
            }

            if (input == "add")
            {
                AddingDates();
            }

            else
            {
                Console.WriteLine("Try Again.");
                Console.WriteLine();
            }
        }
        static void CreateDateTimeObjects()
        {
            DateTime currentDateTime = DateTime.Now; // current date on my computer. Looks at the machine you are running on. 

            DateTime utcNow = DateTime.UtcNow; // The standardized time that can transfer across time zones. 

            DateTime onlyDate = DateTime.Today; // sets the time to midnight because time was not specified. 


            DateTime aDate = new DateTime(); // January 1, 0001

            DateTime specificDate = new DateTime(2008, 6, 15, 21, 15, 7);

            Console.WriteLine();
            Console.WriteLine("The current date and time is: " + DateTime.Now);

            // BELOW IS GETTING A DATE FROM THE USER

            DateTime userDate;

            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("Enter a date: ");
                string input = Console.ReadLine();

                if (DateTime.TryParse(input, out userDate))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("That is not a valid date.");
                    Console.WriteLine("Please try again.");
                    Console.WriteLine("");
                }


            }

            Console.WriteLine("You have selected " + userDate);
            Console.ReadKey();


        }

        static void DifferenceOfDates()
        {
            // will always select the next new years day
            DateTime newYears = new DateTime(DateTime.Today.Year + 1, 1, 1);

            DateTime now = DateTime.Today;

            TimeSpan timeUntilNewYears = newYears.Subtract(now);
            Console.WriteLine("{0} days until New Years. Alright, party!", timeUntilNewYears.Days);

            // this is an example of a free trial

            DateTime freeTrialStart = DateTime.Today;

            // 30 days, 5 hours, 0 minutes, 0 seconds
            TimeSpan daysToExpiry = new TimeSpan(30, 5, 0, 0);

            DateTime freeTrialEnded = freeTrialStart + daysToExpiry;

            Console.WriteLine("You have {0} days till your free trial expires.", daysToExpiry.Days);

            Console.ReadLine();
        }

        static void GettingDayOfYear()
        {
            DateTime d1 = DateTime.Parse("11/4/2019 6:56:00 PM");

            Console.WriteLine("{0} is {1} days into the calendar year!", d1, d1.DayOfYear);

            Console.ReadLine();
        }

        static void AddingDates()
        {
            DateTime date = DateTime.Today;

            // 1 year later
            date = date.AddYears(1);

            //// 2 months later
            //date = date.AddMonths(2);

            //// 1 day, 12 hours later
            //date = date.AddDays(1.5);

            //// 6 hours prior
            //date = date.AddHours(-6);

            //// 150 minutes later
            //date = date.AddMinutes(150);

            //// 10.5 seconds later
            //date = date.AddSeconds(10.5);

            ////499 milliseconds later
            //date = date.AddMilliseconds(499);

            //// 1000 ticks later
            //date = date.AddTicks(1000);

            Console.Write("1 year from now will be {0}/{1}/{2}. Alright, party!", date.Month, date.Day, date.Year);
      

            Console.ReadLine();


        }



    }
}
