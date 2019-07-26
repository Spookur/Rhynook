using System;


// Target Heart Rate Calculator

namespace TargetHeartRateCalculator
{

    public class HeartRates
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public int CurrentYear { get; set; }



        public int PersonsAge //Person`s age property calculation
        {
            get { return CurrentYear - YearOfBirth; }
            set { PersonsAge = value; }
        }

        public int MaximumHeartRate //Maximum Heart rate
        {
            get { return 220 - PersonsAge; }
            set { MaximumHeartRate = value; }
        }

        public string TargetHeartRate //Target heart rate
        {
            get
            {
                double minRate = MaximumHeartRate * (0.5);
                double maxRate = MaximumHeartRate * (0.8);
                return $"{minRate} - {maxRate}";

            }
            set { TargetHeartRate = value; }
        }


        public HeartRates(string firstname, string lastname, int dob, int currentyear)
        {
            FirstName = firstname;
            LastName = lastname;
            YearOfBirth = dob;
            CurrentYear = currentyear;

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            HeartRates calculator = new HeartRates("", "", 0, 0);

            Console.WriteLine("What is your first name?");
            calculator.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            calculator.LastName = Console.ReadLine();

            Console.WriteLine("What is your year of birth?");
            calculator.YearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the current year?");
            calculator.CurrentYear = Convert.ToInt32(Console.ReadLine());

            ///////////////////////////////////////////////////////////////////////

            Console.WriteLine("Your first name is: {0}, and your last name is: {1}.\n" +
                              "You were born in {2}, and the current year is: {3}.",
                              calculator.FirstName, calculator.LastName,
                              calculator.YearOfBirth, calculator.CurrentYear);

            Console.ReadLine();

            Console.WriteLine("Your age is: {0}, your maximum heart rate is: {1}.\n" +
                              "And your Target Heart Rate is in the following range: {2}.",
                              calculator.PersonsAge, calculator.MaximumHeartRate,
                              calculator.TargetHeartRate);
            Console.ReadLine();
        }
    }
}
