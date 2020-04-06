using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            NewGame game = new NewGame();

            game.StartGame();

        }
    }
}