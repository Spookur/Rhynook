using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.BLL
{
    public class GameManager
    {
        private int _answer;

        private bool IsValidGuess(int guess)
        {
            if (guess >= 1 && guess <= 20)
                return true;
            else
                return false; 
        }

        private void CreateRandomAnswer()
        {
            Random rng = new Random();
            _answer = rng.Next(1, 21);
        }

        public GuessResult ProcessGuess(int guess)
        {
            if (!IsValidGuess(guess))
                return GuessResult.Invalid;

            if (guess < _answer)
                return GuessResult.Higher;
            else if (guess > _answer)
                return GuessResult.Lower;
            else
                return GuessResult.Victory;
        }

        public void Start()
        {
            CreateRandomAnswer();
        }

        public void Start(int answer)
        {
            _answer = answer;
        }
    }
}
