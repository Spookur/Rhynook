using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        public static int roundsInput;
        public static bool inPlay = true;
        public static string player;

        static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            string numOfRounds;
            string selectMode;
            int inputMode;
            int computer;
            bool roundsInRange = false;
            int countRounds = 0;
            int countWins = 0;
            int countLoses = 0;
            int countTies = 0;

            IList rpsList = new ArrayList() { "rock", "paper", "scissors" };

            Random r = new Random();

            do
            {
                if (!roundsInRange)
                {
                    Console.WriteLine("Rock Paper Scissors [Max rounds is 10]");
                    Console.WriteLine("Enter the number of rounds: ");
                    numOfRounds = Console.ReadLine();

                    if (int.TryParse(numOfRounds, out roundsInput))
                    {
                        if (roundsInput >= 1 && roundsInput <= 10)
                        {
                            roundsInRange = true;
                        }
                        else if (roundsInput < 1 || roundsInput > 10)
                        {
                            Console.WriteLine("Number out of range");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                            break;
                        }
                    }
                }

                if (roundsInRange)
                {
                    Console.WriteLine("Choose Rock, Paper, or Scissors: ");
                    Console.WriteLine("1 - Rock");
                    Console.WriteLine("2 - Paper");
                    Console.WriteLine("3 - Scissors");
                    selectMode = Console.ReadLine();

                    computer = r.Next(0, rpsList.Count);

                    if (int.TryParse(selectMode, out inputMode))
                    {
                        switch (inputMode)
                        {
                            case 1:
                                player = "rock";
                                break;
                            case 2:
                                player = "paper";
                                break;
                            case 3:
                                player = "scissors";
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                        }
                    }

                    if (player == rpsList[computer].ToString())
                        countTies++;
                    else if (player == "rock" && rpsList[computer].Equals("scissors")
                        || player == "paper" && rpsList[computer].Equals("rock")
                        || player == "scissors" && rpsList[computer].Equals("paper"))
                        countWins++;
                    else countLoses++;

                    countRounds++;
                    Console.WriteLine($"Opponent Answer: {rpsList[computer]}");
                    Console.WriteLine($"Ties: {countTies} Wins: {countWins} Loses: {countLoses}");
                    Reset(countRounds, countWins, countLoses, countTies);
                }
            } while (inPlay);
        }

        public static void Reset(int rounds, int wins, int loses, int ties)
        {
            if (rounds == roundsInput)
            {
                string playAgain;
                if (wins > loses)
                {
                    Console.WriteLine("You win!");
                }
                if (wins == loses)
                {
                    Console.WriteLine("Tie!");
                }
                if (wins < loses)
                {
                    Console.WriteLine("You Lose!");
                }

                Console.WriteLine("Would you like to play again? Type: y/n");
                playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    PlayGame();
                }
                else if (playAgain == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    inPlay = false;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    inPlay = false;
                }
            }
        }
    }
}