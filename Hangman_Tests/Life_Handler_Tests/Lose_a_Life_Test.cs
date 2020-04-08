using System;
using Hangman;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Hangman_Tests.Life_Handler_Tests
{
    [TestClass]
    public class Lose_a_Life_Test
    {
        [TestMethod]
        public void LoseALife_LifeLost_FiveRemain()
        {
            Life_Handler life_Handler = new Life_Handler();

            var Lives = life_Handler.LoseALife(6);

            Assert.AreEqual(5, Lives);
        }
    }
}
