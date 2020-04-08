using System;


namespace Hangman
{
    public class NewGame
    {

        
        public void StartGame() {

            //should be taken out?
            var life_H      = new Life_Handler();
            var gameOutcome = new GameOutcomeDecider();
            var t_Handler   = new Text_Handler();
            var word_H      = new Word_Handler();
            var wGuess_H    = new WordGuess_Handler();
            var userInput   = new Text_Handler();
            //---------------------------------------------

            var repeatGame = false;
            var Lives = 6;


            userInput.ConsoleText("Want to play a game?");

            do
            {
                Console.Clear();

                //  Word Setup ----------------------------

                userInput.ConsoleText("Select Difficulty: Easy (E), Medium (M), Hard (H) or Random (R)");
                string difficultySelected = userInput.UpperUserInput();

                var newWord             = word_H.WordGenerator(difficultySelected);
                var wordToBeGuessedList = word_H.AddingGuessToList(newWord);
                word_H.PrintingLetterOrUnderscoreToConsole(wordToBeGuessedList);

                //------------------------------------------------

                Console.Clear();


                while (Lives != 0)
                {

                    life_H.HangmanDraw(Lives);
                    word_H.PrintingLetterOrUnderscoreToConsole(wordToBeGuessedList);

                    if (repeatGame == true)
                    {
                        break;
                    }

                    t_Handler.BlankLine();
                    t_Handler.BlankLine();
                    wGuess_H.PrintGuessedLetters();
                    t_Handler.BlankLine();
                    t_Handler.ConsoleText("Guess the word:");

                    string userGuess = Console.ReadLine();


                    var input = wGuess_H.WordOrLetterGuess(userGuess, newWord);
                    if (input)
                    {
                        wGuess_H.CheckingLetterGuess(userGuess, wordToBeGuessedList);
                    }
                    else
                    {
                        var guess = wGuess_H.CheckingWordGuess(userGuess, newWord);
                        if (guess)
                        {
                            gameOutcome.GameWon();
                        }
                        else
                        {
                            life_H.LoseALife(Lives);
                        }
                            
                    }
                    

                    Console.Clear();
                }

                gameOutcome.CheckIfUserPlaysAgain(Lives, newWord);
            }

            while (repeatGame == true);
        }



    }
}
