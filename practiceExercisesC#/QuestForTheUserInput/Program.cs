using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestForTheUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            String yourName;
            string yourQuest;
            int velocityOfSwallow; // can change int to a double if wanted

            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();

            Console.WriteLine("What is your quest?");
            yourQuest = Console.ReadLine();

            Console.WriteLine("What is the airspeed velocity of an unladed swallow?!?!?!?!?");
            velocityOfSwallow = Convert.ToInt32(Console.ReadLine()); // can change Convert.ToInt32 to Convert.ToDouble if wanted

            Console.Write("How do you know " + velocityOfSwallow + " is correct, " + yourName + ", ");
            Console.WriteLine("when you don't even know if the swallow was African or European?");
            Console.WriteLine("Maybe skip answering things about birds and instead go " + yourQuest);
            Console.ReadLine();
        }   
    }
}
