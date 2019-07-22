using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {


            //int cpuScore = 0;
            //int score = 0;
            bool playAgain = (true);
            while (playAgain == true)
            {
                List<string> win = new List<string>();//creates the different outcomes where the player wins
                win.Add("13");
                win.Add("21");
                win.Add("32");
                List<string> lose = new List<string>();//creates the different outcomes where the player loses
                lose.Add("12");
                lose.Add("31");
                lose.Add("23");
                List<string> tie = new List<string>();//creates the different outcomes where the player ties
                tie.Add("11");
                tie.Add("22");
                tie.Add("33");


                Console.WriteLine("\nWelcome To Rock Paper Scissors");
                string testString;
                Console.WriteLine("Enter your choice:   1.)Rock  2.)Paper  3.)Scissors");//asks the player for their choice
                testString = Console.ReadLine();
                Console.WriteLine("You entered {0}", testString);

                Random rnd = new Random();
                int cpuChoice = rnd.Next(1, 4);//randomly generates the computers choice
                string cpuString = cpuChoice.ToString();

                string result = (testString + cpuString);//concatonates the two results to make one where it can be checked in the outcome lists
                Console.WriteLine(result);



                if (win.Contains(result))//checks if you won
                {
                    Console.WriteLine("You Won!");
                    //score = (score+1);//adds one to the players score
                }

                else if (lose.Contains(result))//checks if you lost
                {
                    Console.WriteLine("You lost!");
                    //cpuScore = (cpuScore+1);//adds one to the cpu's score
                }
                else if (tie.Contains(result))//checks if there was a tie
                {
                    Console.WriteLine("It's a tie!");
                }

                //Console.Write("Your score is: ");//Outputs the scores
                //Console.WriteLine(score);

                //Console.Write("The computer's score is: ");
                //Console.WriteLine(cpuScore);



                string playInp;
                Console.WriteLine("Do you want to play again? yes or no.");
                playInp = Console.ReadLine();



                if (playInp == "yes")
                {
                    playAgain = (true);
                }
                else if (playInp == "no")
                {
                    playAgain = (false);
                }

            }

        }

    }
}