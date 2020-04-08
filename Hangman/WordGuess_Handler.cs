using System;
using System.Linq;

namespace Hangman
{
    public class WordGuess_Handler
    {

        //----------------Guessing The Word -----------------------------------------------------------

        public void ConfirmingTypeofInput(string userGuess, string newWord)
        {
            if (userGuess.Length == 1)
            {
                CheckingLetterGuess(userGuess);
            }
            else if (userGuess.Count() == newWord.Count())
            {
                CheckingWordGuess(userGuess);
            }
            else
            {
                Console.WriteLine("Not a valid guess, please try again");
            }
            Console.WriteLine();
        }




        public void CheckingLetterGuess(string letter)
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


        public void CheckingWordGuess(string word)
        {
            word = word.ToLower();

            if (newWord == word)
            {
                GameWon();
            }
            else
            {
                Lives = LoseALife(Lives);
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
