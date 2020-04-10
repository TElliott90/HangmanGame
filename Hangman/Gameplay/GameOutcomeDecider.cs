using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public class GameOutcomeDecider
    {

        public bool GameWon(bool gameWon)
        {
            return gameWon = true;
        }


        public bool WordMatch(List<char> userGuessList, string newWord)
        {
            if (userGuessList.ToString() == newWord)
            { 
                return true;
            }

            return false;
        }


        //Needs exceptions
        public bool CheckIfUserPlaysAgain(bool repeatGame)
        {

            Console.WriteLine("Would you like to play again?");
            var answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "y")
            {
                return repeatGame = true;
            }
            else //(answer == "no" || answer == "n")
            {
                return repeatGame = false;
            }
   
        }
    }
}
