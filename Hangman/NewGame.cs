using System;
namespace Hangman
{
    public class NewGame
    {
        GameSetup game;

        public void StartGame() {

            Console.WriteLine("Want to play a game?");

            do
            {
                Console.Clear();
                game = new GameSetup();
                PersonDraw hangMan = new PersonDraw();

                Console.WriteLine("Select Difficulty: Easy (E), Medium (M), Hard (H) or Random (R)");
                string difficultySelected = Console.ReadLine().ToUpper();

                game.WordGenerator(difficultySelected);
                Console.Clear();

                while (game.Lives != 0)
                {
                    hangMan.HangmanDraw(game.Lives);

                    game.PrintingLetterOrUnderscoreToConsole();

                    if (game.repeatGame == true)
                    {
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    game.PrintGuessedLetters();
                    Console.WriteLine();
                    Console.WriteLine("Guess the word:");

                    string userGuess = Console.ReadLine();

                    game.ConfirmingTypeofInput(userGuess);

                    Console.Clear();
                }
                game.CheckIfUserPlaysAgain();
            }
            while (game.repeatGame == true);
        }
    }
    
}
