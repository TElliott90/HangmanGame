using System;
using System.Linq;
using System.Collections.Generic;

namespace Hangman
{
    public class WordGuess_Handler
    {

        //----------------Guessing The Word -----------------------------------------------------------

            //Exception for 
        public bool WordOrLetterGuess(string userGuess)
        {
            if (userGuess.Length == 1)
            {
                return true;
            }
            return false;
        }


        public bool CheckingLetterGuess(char letter, List<char> newWordList)
        {
            foreach(char n in newWordList)
            {
                return true;
            }
            return false;
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


        public char ConvertToChar(string guess)
        {
            return char.Parse(guess);
        }


        public List<char> AddToGuessList(char userGuess, List<char> userGuessList)
        {
            foreach (char n in userGuessList)
            {
                if (userGuess != n)
                {
                    userGuessList.Add(userGuess);
                }
            }
            return userGuessList;
        }

        //------------------------------

       

        public void PrintingUnderscoresToConsole(List<char> wordToBeGuessedList)
        {
            foreach (char n in wordToBeGuessedList)
            {
                Console.WriteLine("_ ");
            }
        }


        //Letter or Underscore
        #region
        public void PrintingLetterOrUnderscoreToConsole(List<char> wordToBeGuessedList)
        {
            Console.WriteLine();

            foreach (char n in wordToBeGuessedList)
            {
                Console.WriteLine("_ ");
            }

            //wordToBeGuessedList[0].ToUpper(wordToBeGuessedList[0]);
        }
        #endregion



        public void LetterCompare(List<char> guessedWordList, List<char> wordToBeGuessedList)
        {



        }


    }
}
