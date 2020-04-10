using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public class Text_Handler
    {
        
        public void ConsoleText(string message)
        {
            Console.WriteLine(message);
        }

        public void BlankLine()
        {
            Console.WriteLine();
        }

        public string UpperUserInput()
        {
            return Console.ReadLine().ToUpper();
        }


        public void DisplayCharList(List<char> userGuesslist)
        {
            foreach(char n in userGuesslist)
            {
                Console.Write($"{n} ");
            }
        }

        public List<string> AddUnderscores(List<string> guessList, string guessWord)
        {
            foreach(char n in guessWord)
            {
                guessList.Add("_ ");
               
            }

            return guessList;
        }


        public void GameOverMessage(bool gameWon, string newWord, Life_Handler life_Handler, int Lives)
        {
            if (gameWon)
            {
                life_Handler.HangmanDraw(Lives);
                Console.WriteLine(newWord);
                Console.WriteLine();
                Console.WriteLine("Congratulations! You won!");
                Console.WriteLine("Would you like to play again?");
            }
            else
            {
                newWord = newWord.ToUpper();
                life_Handler.HangmanDraw(Lives);
                Console.WriteLine();
                Console.WriteLine("Game Over!");
                Console.WriteLine($"The answer was {newWord}! ");
            }
        }

    }
}
