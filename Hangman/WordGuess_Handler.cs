using System;
using System.Linq;
using System.Collections.Generic;

namespace Hangman
{
    public class WordGuess_Handler
    {

        //----------------Guessing The Word -----------------------------------------------------------

        public bool WordOrLetterGuess(string userGuess, string newWord)
        {
            try
            {
                if (userGuess.Length == 1)
                {
                    return true;
                }
                else if (userGuess.Count() == newWord.Count())
                {
                    return false;
                }
            }
            catch
            {
                throw Exception;
            };

        }




        public void CheckingLetterGuess(string letter, List<char> newWordList)
        {

            


            for (int i = 0; i < letter.Length; i++)
            {
                //checking previous answer
                if (IncorrectGuessedLetters.Count >= 1 || CorrectGuessedLetters.Count >= 1)
                {
                    if (IncorrectGuessedLetters.Contains(letter) || CorrectGuessedLetters.Contains(letter))
                    {
                        Console.WriteLine("Letter already guessed, please try another");
                        break;
                    }
                }

                // If its matches
                if (wordToBeGuessed.Contains(letter))
                {
                    CorrectGuessedLetters.Add(letter);

                }
                //if it doesn't
                else
                {
                    Lives = LoseALife(Lives);
                    IncorrectGuessedLetters.Add(letter);
                }
            }
        }


        public bool CheckingWordGuess(string word,string newWord)
        {
            word = word.ToLower();

            if (newWord == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void PrintGuessedLetters()
        {
            if (IncorrectGuessedLetters.Count > 0)
            {
                Console.WriteLine("Incorrect Letters:");
                IncorrectGuessedLetters.ForEach(Console.Write);
            }
        }
    }
}
