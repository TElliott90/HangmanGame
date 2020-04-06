using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hangman
{
    public class GameSetup
    {

        // --------------Getting the Word --------------------------------------------------------------

        public List<string> wordToBeGuessed = new List<string>();
        public List<string> IncorrectGuessedLetters = new List<string>();
        public List<string> CorrectGuessedLetters = new List<string>();


        public int Lives = 6;

        public string newWord;

        public bool repeatGame = false;

        public void WordGenerator(string difficultySelected)
        {
            List<string> EasyWords = new List<string> { "Bird", "Tree", "Wood", "Fire", "Tech" };
            List<string> MediumWords = new List<string> { "Wales", "Rugby", "Calling", "Content", "Website" };
            List<string> HardWords = new List<string> { "Halloween", "Technology", "Graduate", "Developer", "Incredible" };
            List<string> RandomWords = File.ReadLines(@"C:\Users\elliott\Documents\TechAcademy\PracticeProjects\PostPresHangman_Practice\Hangman_Practice\bin\Debug\netcoreapp2.2\Text_List.txt").ToList();
            var random = new Random();

            switch (difficultySelected)
            {
                case "E":
                    {
                        int randomIndex = random.Next(EasyWords.Count);
                        newWord = EasyWords[randomIndex].ToLower();
                        AddingGuessToList(newWord);
                        break;
                    }
                case "M":
                    {
                        int randomIndex = random.Next(MediumWords.Count);
                        newWord = MediumWords[randomIndex].ToLower();
                        AddingGuessToList(newWord);
                        break;
                    }
                case "H":
                    {
                        int randomIndex = random.Next(HardWords.Count);
                        newWord = HardWords[randomIndex].ToLower();
                        AddingGuessToList(newWord);
                        break;
                    }
                case "R":
                    {
                        int randomIndex = random.Next(RandomWords.Count);
                        newWord = RandomWords[randomIndex].ToLower();
                        AddingGuessToList(newWord);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid option");
                        break;
                    }
            }
        }

        public void AddingGuessToList(string newWord)
        {
            for (int i = 0; i < newWord.Length; i++)
            {
                wordToBeGuessed.Add(Char.ToString(newWord[i]));
            }
        }

        //-------------------------------------------------------------------------------------------------------------

        public void PrintingLetterOrUnderscoreToConsole()
        {
            Console.WriteLine();

            string[] PrintedWordsOrUnderscores = new string[newWord.Length];

            for (int i = 0; i < wordToBeGuessed.Count(); i++)
            {
                PrintedWordsOrUnderscores[i] = "_ ";
            }

            if (CorrectGuessedLetters.Count > 0)
            {
                for (int i = 0; i < CorrectGuessedLetters.Count; i++)
                {
                    for (int j = 0; j < wordToBeGuessed.Count; j++)
                    {
                        if (CorrectGuessedLetters[i] == wordToBeGuessed[j])
                        {
                            PrintedWordsOrUnderscores[j] = wordToBeGuessed[j];
                        }
                    }
                }
            }

            PrintedWordsOrUnderscores[0] = PrintedWordsOrUnderscores[0].ToUpper();


            for (int i = 0; i < PrintedWordsOrUnderscores.Length; i++)
            {
                Console.Write(PrintedWordsOrUnderscores[i]);
            }

            if (!PrintedWordsOrUnderscores.Contains("_ "))
            {
                GameWon();
            }
        }


        //----------------Guessing The Word -----------------------------------------------------------


        public void ConfirmingTypeofInput(string userGuess)
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

        public int LoseALife(int Lives)
        {
            Lives -= 1;
            return Lives;
        }

        public void GameWon()
        {
            repeatGame = true;
        }

        public void GameOver()
        {
            newWord = newWord.ToUpper();
            PersonDraw hangMan = new PersonDraw();
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

        public void CheckIfUserPlaysAgain()
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
