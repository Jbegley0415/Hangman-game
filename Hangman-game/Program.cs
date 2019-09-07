using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize
            int incorrectGuesses = 0;
            char[] correctGuess = new char[4];
            Console.WriteLine("Welcome to Hangman\n5 wrong guesses loses!! \nEnter your first guess: _ _ _ _");
            //begin incorrect guess loop, to track user progress and failure.
            while (incorrectGuesses < 5)
            {
                char userGuess;
                //Validates that the user entered a character and stores it in the userGuess variable.
                if (char.TryParse(Console.ReadLine(), out userGuess))
                {
                    //Validates that the character is between a-z upper or lowercase.
                    if ((userGuess >= 'a' && userGuess <= 'z') || (userGuess >= 'A' && userGuess <= 'Z'))
                    {
                        //checking for correct guess
                        if (userGuess == 'l' || userGuess == 'L')
                        {
                            correctGuess[0] = 'L';
                            DisplayCorrectText(correctGuess);
                        }
                        else if (userGuess == 'i' || userGuess == 'I')
                        {
                            correctGuess[1] = 'I';
                            DisplayCorrectText(correctGuess);
                        }
                        else if (userGuess == 'o' || userGuess == 'O')
                        {
                            correctGuess[2] = 'O';
                            DisplayCorrectText(correctGuess);
                        }
                        else if (userGuess == 'n' || userGuess == 'N')
                        {
                            correctGuess[3] = 'N';
                            DisplayCorrectText(correctGuess);
                        }
                        else
                        {
                            //counts the guess if incorrect and displays wrong guess message.
                            incorrectGuesses++;
                            Console.WriteLine("-----------------");
                            Console.WriteLine("     Wrong!!     ");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("\nYou have {0} more guesses! \nTry again!", 5 - incorrectGuesses);
                        }
                        //checking user input for winning the game, and diplaying win message if true.
                        if ((correctGuess[0] == 'l' || correctGuess[0] == 'L') && (correctGuess[1] == 'i' || correctGuess[1] == 'I') &&
                            (correctGuess[2] == 'o' || correctGuess[2] == 'O') && (correctGuess[3] == 'N' || correctGuess[3] == 'n'))
                        {
                            Console.WriteLine("\nYOU WIN!!!!");
                            Console.WriteLine("press any key to exit");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        //character validation error message.
                        Console.WriteLine("Please enter a single letter");
                    }
                }
                else
                {
                    ////character validation error message.
                    Console.WriteLine("Please enter a single letter");
                }
            }
        }

        //method displaying correct error message.
        public static void DisplayCorrectText(char[] Array)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Correct!!");
            Console.WriteLine("-----------------\n");
            Console.Write("So far you have found: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i]);
            }
            Console.WriteLine("\n                       ----");
            Console.WriteLine("\n-------------------");
            Console.WriteLine("guess again!!");
            Console.WriteLine("-----------------\n");
        }
    }
    }
}
