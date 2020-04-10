using System;
using System.Linq;
using System.Collections.Generic;

namespace Hangman
{
    public class Word_Generator
    {

        // Letter check needed
        #region Word Generator
        public string WordGenerator(string difficultySelected)
        {
            List<string> EasyWords = new List<string> { "Bird", "Tree", "Wood", "Fire", "Tech" };
            List<string> MediumWords = new List<string> { "Wales", "Rugby", "Calling", "Content", "Website" };
            List<string> HardWords = new List<string> { "Halloween", "Technology", "Graduate", "Developer", "Incredible"};
            //List<string> RandomWords = File.ReadLines(@"\bin\Debug\netcoreapp3.1\Text_List.txt").ToList();

            Random random = new Random();
            string newWord = "default";

            while (difficultySelected != "E" | difficultySelected != "M" | difficultySelected != "H")
            {
                            Console.WriteLine("Incorrect choice, please select again");
                            difficultySelected = Console.ReadLine().ToUpper();
                            break;
            }

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


            return newWord;
        }
        #endregion

        public List<char> CharListForWord(string newWord)
        {
            List<char> wordToBeGuessed = new List<char>();

            foreach(char l in newWord)
            {
                wordToBeGuessed.Add(l);
            }
            return wordToBeGuessed;
        }

    }
}
