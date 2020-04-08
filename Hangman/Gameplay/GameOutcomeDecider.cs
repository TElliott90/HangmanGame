using System;
namespace Hangman
{
    public class GameOutcomeDecider
    {

        public bool GameWon()
        {
            return repeatGame = true;
        }



        public void GameOver()
        {
            newWord = newWord.ToUpper();
            Life_Handler hangMan = new Life_Handler();
            hangMan.HangmanDraw(0);


            Console.WriteLine("Game Over!");
            Console.WriteLine($"The answer was {newWord}! ");

            Console.WriteLine("Would you like to play again?");
            var answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "y")
            {
                repeatGame = true;
            }
            else if (answer == "no" || answer == "n")
            {
                repeatGame = false;
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }



        public void CheckIfUserPlaysAgain(int Lives)
        {
            if (Lives == 0)
            {
                GameOver();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Congratulations! You won!");
                Console.WriteLine("Would you like to play again?");
                repeatGame = true;

                var answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
                {
                    repeatGame = true;
                }
                else if (answer == "no" || answer == "n")
                {
                    repeatGame = false;

                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
        }
    }
}
