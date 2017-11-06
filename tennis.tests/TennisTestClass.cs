using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace tennis.tests
{
    [TestClass]
    public class TennisTestsClass
    {
        private Match match { get; set; }

        [TestInitialize]
        public void MatchInitialize()
        {
            match = new Match("Pepo", "Supu", 3);
        }

        [TestMethod]
        public void Test_IsSetFinished()
        {
            match.player1.games = 6;
            match.player1.games = 5;

            Assert.IsFalse(match.IsSetFinished());
        }

        [TestMethod]
        public void Test_IsGameFinished()
        {

            match.player1.points = 6;
            match.player1.games = 4;

            Assert.IsTrue(match.IsGameFinished());
        }

        [TestMethod]
        public void Test_RandomPlayer()
        {
            Player playerRandom = match.RandomPlayer();
            List<string> listNames = new List<string>() { match.player1.name, match.player2.name };

            Assert.IsTrue(listNames.Contains(playerRandom.name));
        }
    }
}
