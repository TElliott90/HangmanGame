using System;
namespace Hangman
{
    public class Text_Handler
    {
        
        public void ConsoleText(string message)
        {
            Console.WriteLine(message);
        }


        public void BlankSpace()
        {
            Console.WriteLine();
        }


        public string UpperUserInput()
        {
            return Console.ReadLine().ToUpper();
        }


        
    }
}
