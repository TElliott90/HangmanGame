using System;
using System.Collections.Generic;


namespace Hangman
{
    public class NewGame
    {


        public void StartGame()
        {

            //should be taken out?
            var life_H = new Life_Handler();
            var gameOutcome = new GameOutcomeDecider();
            var t_Handler = new Text_Handler();
            var word_H = new Word_Generator();
            var wGuess_H = new WordGuess_Handler();
            
            //---------------------------------------------


            #region Variables
            var repeatGame = false;
            var gameWon = false;
            var Lives = 6; 
            #endregion

            #region Lists
            List<char> userGuessedList = new List<char>();           
            List<char> guessList       = new List<char>();
            #endregion


            t_Handler.ConsoleText("Want to play a game?");


            do
            {
                Console.Clear();

                //  Word Setup ----------------------------

               t_Handler.ConsoleText("Select Difficulty: Easy (E), Medium (M), Hard (H) or Random (R)");
                string difficultySelected = t_Handler.UpperUserInput();

                //Word to guess
                var newWord             = word_H.WordGenerator(difficultySelected);

                //Word seperated into char's and stored in list
                var wordToBeGuessedList = word_H.CharListForWord(newWord);
                wGuess_H.PrintingLetterOrUnderscoreToConsole(wordToBeGuessedList);

                //------------------------------------------------

                Console.Clear();


                //Game Rules
                while (Lives != 0 | gameWon == false)
                {


                    //Console Display
                    life_H.HangmanDraw(Lives);

                    if(userGuessedList.Count != 0)
                    {
                        t_Handler.BlankLine();
                        t_Handler.DisplayCharList(userGuessedList);
                    }

                    t_Handler.BlankLine();

                    //displays guess List either underscore or letter
                    t_Handler.DisplayCharList(guessList);



                    wGuess_H.PrintingLetterOrUnderscoreToConsole(wordToBeGuessedList);

                    //?
                    if (repeatGame == true)
                    {
                        break;
                    }

                    t_Handler.BlankLine();
                    t_Handler.BlankLine();
                    t_Handler.BlankLine();


                    // User guesses ---------------------------------------------
                    t_Handler.ConsoleText("Guess the word:");
                    var stringGuess = Console.ReadLine();
                    var input = wGuess_H.WordOrLetterGuess(stringGuess);

                    // If guess is a letter
                        if (input)
                        {
                             var letter = wGuess_H.ConvertToChar(stringGuess);
                             var letterGuess = wGuess_H.CheckingLetterGuess(letter, wordToBeGuessedList);
                                if (letterGuess)
                                {    //Replace underscore with letter (M)
                                    wGuess_H.AddToGuessList(letter, userGuessedList);

                                    var match = gameOutcome.WordMatch(userGuessedList, newWord);
                                    if (match)
                                    {
                                    gameOutcome.GameWon(gameWon);
                                    }
                                }
                                else
                                {
                                    life_H.LoseALife(Lives);
                                    wGuess_H.AddToGuessList(letter,userGuessedList);
                                }
                        }

                        // Guess is a Word
                        else
                        {
                            var guess = wGuess_H.CheckingWordGuess(stringGuess, newWord);
                                if (guess)
                                {
                                    gameOutcome.GameWon(gameWon);
                                }
                                else
                                {
                                    life_H.LoseALife(Lives);
                                }
                        }

                    Console.Clear();
                }

                t_Handler.GameOverMessage(gameWon, newWord, life_H, Lives);
                gameOutcome.CheckIfUserPlaysAgain(repeatGame);
            }

            while (repeatGame == true);
        }
    } 
}
