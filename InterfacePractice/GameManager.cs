using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class GameManager
    {

        private IChoiceGetter _chooser;

        public GameManager(IChoiceGetter concrete)
        {
            _chooser = concrete;
        }

        public PlayRoundResponse PlayRound(Choice player1Choice)
        {
            PlayRoundResponse response = new PlayRoundResponse();
            response.Player1Choice = player1Choice;
            response.Player2Choice = GetChoice();

            //TIE?

            if (response.Player1Choice == response.Player2Choice)
            {
                response.Player1Result = GameResult.Tie;
                return response;
            }

            // PLAYER 1 WINS?

            if (response.Player1Choice == Choice.Rock && response.Player2Choice == Choice.Scissors ||
                response.Player1Choice == Choice.Scissors && response.Player2Choice == Choice.Paper ||
                response.Player1Choice == Choice.Paper && response.Player2Choice == Choice.Rock)
            {
                response.Player1Result = GameResult.Win;
                return response;
            }

            else
            {
                response.Player1Result = GameResult.Loss;
                return response;
            }

            private Choice GetChoice()
            {
                Random rng = new Random();
                int num = rng.Next(1, 4);

                return (Choice)num;
            }
        }
    }
}
