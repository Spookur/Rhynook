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
            PlayGame(); // method that is called when program starts.
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

            IList rpsList = new ArrayList() { "rock", "paper", "scissors" }; // Create array of the three options. 

            Random r = new Random(); // random number local variable "r"

            do // I used a "do" loop because I want the code block to be executed before the condition is checked.
            {
                if (!roundsInRange) // This loop makes sure the player enters a valid number of rounds.
                {
                    Console.WriteLine("Rock Paper Scissors [Max rounds is 10]");
                    Console.WriteLine("Enter the number of rounds: ");
                    numOfRounds = Console.ReadLine();

                    if (int.TryParse(numOfRounds, out roundsInput)) // I use int.TryParse to convert the numOfRounds variable to an int type. 
                    {
                        if (roundsInput >= 1 && roundsInput <= 10)
                        {
                            roundsInRange = true; // selecting a number within range will start the game.
                        }
                        else if (roundsInput < 1 || roundsInput > 10)
                        {
                            Console.WriteLine("Number out of range. Please select a number of rounds in range of 1-10."); // selecting a number out of range displays this.
<<<<<<< HEAD


                        }

=======
                            
                            
                        }
                        
>>>>>>> 304e6f5ba3183befbaa40d8ac3ea508be8fb3e32
                    }
                }

                if (roundsInRange) // Once a valid number of rounds are selected, the game prompts you to pick one of three options. 
                {
                    Console.WriteLine("Choose Rock, Paper, or Scissors: ");
                    Console.WriteLine("1 - Rock");
                    Console.WriteLine("2 - Paper");
                    Console.WriteLine("3 - Scissors");
                    selectMode = Console.ReadLine();

                    computer = r.Next(0, rpsList.Count); // After selecting a number, the computer rolls a number from the array. 

                    if (!int.TryParse(selectMode, out inputMode) || inputMode < 1 || inputMode > 3) // takes the user's input and converts it to an integer within 1-3 range.
                    {
                        continue; // This "if" loop makes sure the player has selected a number 1-3. 
<<<<<<< HEAD
=======
                    }
                    switch (inputMode) // defines what each option actually is upon selection. Rock, paper, or scissors. 
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
>>>>>>> 304e6f5ba3183befbaa40d8ac3ea508be8fb3e32
                    }
                    switch (inputMode) // defines what each option actually is upon selection. Rock, paper, or scissors. 
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


<<<<<<< HEAD
                    if (player == rpsList[computer].ToString())
                        countTies++; // if the player selects the same number that the computer generates, the result is a tie. 
                    else if (player == "rock" && rpsList[computer].Equals("scissors")
=======

                    if (player == rpsList[computer].ToString()) 
                        countTies++; // if the player selects the same number that the computer generates, the result is a tie. 
                    else if (player == "rock" && rpsList[computer].Equals("scissors") 
>>>>>>> 304e6f5ba3183befbaa40d8ac3ea508be8fb3e32
                        || player == "paper" && rpsList[computer].Equals("rock") // every possible outcome that results in a win for the player. 
                        || player == "scissors" && rpsList[computer].Equals("paper"))
                        countWins++;
                    else countLoses++; // any other outcome will result in a loss. 

                    countRounds++; // the number of rounds are going up by 1. 
<<<<<<< HEAD
                    Console.WriteLine($"Opponent Answer: {rpsList[computer]}");
                    Console.WriteLine($"Ties: {countTies} Wins: {countWins} Loses: {countLoses}");

                    inPlay = Reset(countRounds, countWins, countLoses, countTies);
=======
                    Console.WriteLine($"Opponent Answer: {rpsList[computer]}"); 
                    Console.WriteLine($"Ties: {countTies} Wins: {countWins} Loses: {countLoses}");

                    inPlay = Reset(countRounds, countWins, countLoses, countTies); 
>>>>>>> 304e6f5ba3183befbaa40d8ac3ea508be8fb3e32

                }
            } while (inPlay); // all the statements inside the "do" are performed and then the condition (inPlay) is checked. 
        }

        public static bool Reset(int rounds, int wins, int loses, int ties)
        {
            if (rounds != roundsInput) // Until the amount of rounds are played, the loop will continue. 
            {
                return true;
            }
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
<<<<<<< HEAD

            Console.WriteLine("Would you like to play again? Type: y/n");
            playAgain = Console.ReadLine().ToLower();

            if (playAgain == "y")
            {
                Console.WriteLine("Good luck! (Press enter to continue)");
                Console.ReadLine();
                PlayGame();
                return true;

            }
            else if (playAgain == "n")
            {
                Console.WriteLine("Thanks for playing!");
                Console.ReadLine();
                return false;


=======

            Console.WriteLine("Would you like to play again? Type: y/n");
            playAgain = Console.ReadLine().ToLower();

            if (playAgain == "y")
            {
                Console.WriteLine("Good luck! (Press enter to continue)");
                Console.ReadLine();
                PlayGame();
                return true;
                
            }
            else if (playAgain == "n")
            {
                Console.WriteLine("Thanks for playing!");
                Console.ReadLine();
                return false;
                
                
>>>>>>> 304e6f5ba3183befbaa40d8ac3ea508be8fb3e32
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();


                return false;
<<<<<<< HEAD

=======
                
>>>>>>> 304e6f5ba3183befbaa40d8ac3ea508be8fb3e32
            }



<<<<<<< HEAD

        }

    }
=======
                 
        }
        
    }   
>>>>>>> 304e6f5ba3183befbaa40d8ac3ea508be8fb3e32
}