using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class Life_Handler
    {

        public int LoseALife(int Lives)
        {
            Lives -= 1;
            return Lives;
        }


        public void HangmanDraw(int Lives)
        {
            switch (Lives)
            {

                case 6:
                    Console.WriteLine(" ______    ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|__________");
                    break;

                case 5:
                    Console.WriteLine(" ______    ");
                    Console.WriteLine("|     |    ");
                    Console.WriteLine("|     O    ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|__________");
                    break;


                case 4:
                    Console.WriteLine(" ______    ");
                    Console.WriteLine("|     |    ");
                    Console.WriteLine("|     O    ");
                    Console.WriteLine("|     |    ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|__________");
                    break;

                case 3:
                    Console.WriteLine(" ______    ");
                    Console.WriteLine("|     |    ");
                    Console.WriteLine("|     O    ");
                    Console.WriteLine("|    /|    ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|          ");
                    Console.WriteLine("|__________");
                    break;

                case 2:
                    Console.WriteLine( " ______    ");
                    Console.WriteLine( "|     |    ");
                    Console.WriteLine( "|     O    ");
                    Console.WriteLine(@"|    /|\   ");
                    Console.WriteLine( "|          ");
                    Console.WriteLine( "|          ");
                    Console.WriteLine( "|__________");
                    break;

                case 1:
                    Console.WriteLine( " ______    ");
                    Console.WriteLine( "|     |    ");
                    Console.WriteLine( "|     O    ");
                    Console.WriteLine(@"|    /|\   ");
                    Console.WriteLine( "|    /     ");
                    Console.WriteLine( "|          ");
                    Console.WriteLine( "|__________");
                    break;

                case 0:
                    Console.WriteLine( " ______    ");
                    Console.WriteLine( "|     |    ");
                    Console.WriteLine( "|     O    ");
                    Console.WriteLine(@"|    /|\   ");
                    Console.WriteLine(@"|    / \   ");
                    Console.WriteLine( "|          ");
                    Console.WriteLine( "|__________");
                    break;
            }
        }
    }
}
