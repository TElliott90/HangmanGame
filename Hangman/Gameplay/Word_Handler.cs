using System;
using System.Linq;
using System.Collections.Generic;

namespace Hangman
{
    public class Word_Handler
    {
        // --------------Getting the Word --------------------------------------------------------------

        public List<string> wordToBeGuessed2;
        public List<string> IncorrectGuessedLetters = new List<string>();
        public List<string> CorrectGuessedLetters = new List<string>();

        public int Lives = 6;
        public string newWord;
        public bool repeatGame = false;



        // Letter check needed
        #region
        public string WordGenerator(string difficultySelected)
        {
            List<string> EasyWords = new List<string> { "Bird", "Tree", "Wood", "Fire", "Tech" };
            List<string> MediumWords = new List<string> { "Wales", "Rugby", "Calling", "Content", "Website" };
            List<string> HardWords = new List<string> { "Halloween", "Technology", "Graduate", "Developer", "Incredible" };
            //List<string> RandomWords = File.ReadLines(@"\bin\Debug\netcoreapp3.1\Text_List.txt").ToList();

            Random random = new Random();
            string newWord = "default";

            switch (difficultySelected)
            {
                case "E":
                    {
                        int randomIndex = random.Next(EasyWords.Count);
                        newWord = EasyWords[randomIndex].ToLower();
                        break;
                    }
                case "M":
                    {
                        int randomIndex = random.Next(MediumWords.Count);
                        newWord = MediumWords[randomIndex].ToLower();
                        break;
                    }
                case "H":
                    {
                        int randomIndex = random.Next(HardWords.Count);
                        newWord = HardWords[randomIndex].ToLower();
                        break;
                    }
            }

            return newWord;



            /*
        case "R":
            {
                int randomIndex = random.Next(RandomWords.Count);
                newWord = RandomWords[randomIndex].ToLower();
                AddingGuessToList(newWord);
                return newWord;
                break;
            }
            */

            /* else

                    {
                        Console.WriteLine("Not a valid option");
                        break;
                    }
            */
        }
        
        
        #endregion



        public List<char> AddingGuessToList(string newWord)
        {
            List<char> wordToBeGuessedList = new List<char>();

            for (int i = 0; i < newWord.Length; i++)
            {
                wordToBeGuessedList.Add(newWord[i]);
            }
            return wordToBeGuessedList;
        }



        //Letter or Underscore
        #region
        public void PrintingLetterOrUnderscoreToConsole(List<char> wordToBeGuessedList)
        {
            Console.WriteLine();

           // List<char> wordtoGuess = new List<char>(wordToBeGuessedList);

            foreach(char n in wordToBeGuessedList)
            {
                Console.WriteLine("_ ");
            }



            /* string[] PrintedWordsOrUnderscores = new string[newWord.Length];

            for (int i = 0; i < wordToBeGuessed2.Count(); i++)
            {
                PrintedWordsOrUnderscores[i] = "_ ";
            }

            if (CorrectGuessedLetters.Count > 0)
            {
                for (int i = 0; i < CorrectGuessedLetters.Count; i++)
                {
                    for (int j = 0; j < wordToBeGuessed2.Count; j++)
                    {
                        if (CorrectGuessedLetters[i] == wordToBeGuessed2[j])
                        {
                            PrintedWordsOrUnderscores[j] = wordToBeGuessed2[j];
                        }
                    }
                }
            }

            PrintedWordsOrUnderscores[0] = PrintedWordsOrUnderscores[0].ToUpper();


            for (int i = 0; i < PrintedWordsOrUnderscores.Length; i++)
            {
                Console.Write(PrintedWordsOrUnderscores[i]);
            }
            */

            
        }
        #endregion

        public void LetterCompare(List<char> guessedWordList, List<char> wordToBeGuessedList)
        {

            
            
        }



    }
}
