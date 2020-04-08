using System;
namespace Hangman
{
    public class NewGame
    {
        
        public void StartGame() {


            var life_H      = new Life_Handler();
            var gameOutcome = new GameOutcomeDecider();
            var t_Handler   = new Text_Handler();
            var word_H      = new Word_Handler();
            var wGuess_H    = new WordGuess_Handler();
            var userInput   = new Text_Handler();

            var repeatGame = false;


            userInput.ConsoleText("Want to play a game?");

            do
            {
                Console.Clear();

                userInput.ConsoleText("Select Difficulty: Easy (E), Medium (M), Hard (H) or Random (R)");
                string difficultySelected = userInput.UpperUserInput();

                word_H.WordGenerator(difficultySelected);
                Console.Clear();

                while (life_H.Lives != 0)
                {
                    life_H.HangmanDraw(life_H.Lives);
                    word_H.PrintingLetterOrUnderscoreToConsole();


                    if (repeatGame == true)
                    {
                        break;
                    }


                    t_Handler.BlankSpace();
                    t_Handler.BlankSpace();
                    wGuess_H.PrintGuessedLetters();
                    t_Handler.BlankSpace();
                    t_Handler.ConsoleText("Guess the word:");

                    string userGuess = Console.ReadLine();

                    wGuess_H.ConfirmingTypeofInput(userGuess);

                    Console.Clear();
                }
                gameOutcome.CheckIfUserPlaysAgain();
            }
            while (repeatGame == true);
        }
    }
    
}
