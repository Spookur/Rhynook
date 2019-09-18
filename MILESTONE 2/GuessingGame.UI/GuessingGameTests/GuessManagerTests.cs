using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GuessingGame.BLL;

namespace GuessingGameTests
{
    [TestFixture]
    public class GuessManagerTests
    {
        [Test]
        public void InvalidGuessTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start();

            GuessResult actual = gameInstance.ProcessGuess(152);
            Assert.AreEqual(GuessResult.Invalid, actual);
        }

        [Test]
        public void LowerGuessResult()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(10);

            GuessResult actual = gameInstance.ProcessGuess(12);
            Assert.AreEqual(GuessResult.Lower, actual);
        }

        [Test]
        public void HigherGuessResult()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(10);

            GuessResult actual = gameInstance.ProcessGuess(10);
            Assert.AreEqual(GuessResult.Victory, actual);
        }
    }
}
