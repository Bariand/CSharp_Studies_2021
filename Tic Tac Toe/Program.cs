/*Programmer: Lucas Freitas Cordeiro. Date: 27/10/2021, Brazil;
  This program was my solution to the Tic Tac Toe Challenge from Denis Panjutas' "Complete C# Masterclass" course;
  This was my first attempt to ever create a functioning program. It was made before I've got myself into encapsulation and clean code and uses
  only simple, basic methods and logic to get the job done.*/

using System;
using System.Threading;

namespace Tic_Tac_Toe
{
    internal static class Program
    {
        private static int turnCounter;
        private static char playerSymbol;
        private static string playerArticle;
        private static string playerName;

        private static readonly char[,] gameBoard =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' },
        };

        private static void Main()
        {
            Console.Clear();
            Reset();
            DrawTitleScreen();

            //Checks if the game was a draw
            while (turnCounter < 10)
            {
                Console.Clear();
                DrawTable();

                //Checks if P1 won
                if ((gameBoard[0, 0] == 'X' && gameBoard[0, 1] == 'X' && gameBoard[0, 2] == 'X') ||
                    (gameBoard[1, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[1, 2] == 'X') ||
                    (gameBoard[2, 0] == 'X' && gameBoard[2, 1] == 'X' && gameBoard[2, 2] == 'X') ||
                    (gameBoard[0, 0] == 'X' && gameBoard[1, 0] == 'X' && gameBoard[2, 0] == 'X') ||
                    (gameBoard[0, 1] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 1] == 'X') ||
                    (gameBoard[0, 2] == 'X' && gameBoard[1, 2] == 'X' && gameBoard[2, 2] == 'X') ||
                    (gameBoard[0, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 2] == 'X') ||
                    (gameBoard[0, 2] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 0] == 'X'))
                {
                    Console.WriteLine("    ");
                    Console.WriteLine("PLAYER 1 OF THE MIGHTY 'X' WINS!");
                    Console.WriteLine("    ");
                    Console.ReadKey();
                    Console.WriteLine("Press any key to restart");
                    Console.ReadKey();
                    Main();
                }

                //Checks if P2 won
                if ((gameBoard[0, 0] == 'O' && gameBoard[0, 1] == 'O' && gameBoard[0, 2] == 'O') ||
                    (gameBoard[1, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[1, 2] == 'O') ||
                    (gameBoard[2, 0] == 'O' && gameBoard[2, 1] == 'O' && gameBoard[2, 2] == 'O') ||
                    (gameBoard[0, 0] == 'O' && gameBoard[1, 0] == 'O' && gameBoard[2, 0] == 'O') ||
                    (gameBoard[0, 1] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 1] == 'O') ||
                    (gameBoard[0, 2] == 'O' && gameBoard[1, 2] == 'O' && gameBoard[2, 2] == 'O') ||
                    (gameBoard[0, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 2] == 'O') ||
                    (gameBoard[0, 2] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 0] == 'O'))
                {
                    Console.WriteLine("    ");
                    Console.WriteLine("PLAYER 2 OF THE GREAT 'O' WINS!");
                    Console.WriteLine("    ");
                    Console.ReadKey();
                    Console.WriteLine("Press any key to restart");
                    Console.ReadKey();
                    Main();
                }

                if (turnCounter == 0)
                {
                    Reset();
                }

                ++turnCounter;

                //Checks if it's P1's or P1's turn
                if (turnCounter % 2 == 0)
                {
                    playerSymbol = 'O';
                    playerArticle = "an";
                    playerName = "Player 2";
                }
                else
                {
                    playerSymbol = 'X';
                    playerArticle = "a";
                    playerName = "Player 1";
                }

                int i;

                //Game loop
                do
                {
                    Console.WriteLine("{0}, please select a field to draw {1} '{2}' in it: ", playerName, playerArticle, playerSymbol);
                    string input = Console.ReadLine();

                    //Methods below check for valid inputs (1 to 9 only)
                    if (input != "0")
                    {
                        i = 0;

                        try
                        {
                            i = 0;
                            int convertedInput = Convert.ToInt32(input);

                            switch (convertedInput)
                            {
                                case 1:
                                    //These 'if statements' check if the selected cell isn't already taken by a sign
                                    if (gameBoard[0, 0] != 'X' && gameBoard[0, 0] != 'O')
                                    {
                                        gameBoard[0, 0] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }

                                case 2:
                                    if (gameBoard[0, 1] != 'X' && gameBoard[0, 1] != 'O')
                                    {
                                        gameBoard[0, 1] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }
                                case 3:
                                    if (gameBoard[0, 2] != 'X' && gameBoard[0, 2] != 'O')
                                    {
                                        gameBoard[0, 2] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }
                                case 4:
                                    if (gameBoard[1, 0] != 'X' && gameBoard[1, 0] != 'O')
                                    {
                                        gameBoard[1, 0] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }
                                case 5:
                                    if (gameBoard[1, 1] != 'X' && gameBoard[1, 1] != 'O')
                                    {
                                        gameBoard[1, 1] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }
                                case 6:
                                    if (gameBoard[1, 2] != 'X' && gameBoard[1, 2] != 'O')
                                    {
                                        gameBoard[1, 2] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }
                                case 7:
                                    if (gameBoard[2, 0] != 'X' && gameBoard[2, 0] != 'O')
                                    {
                                        gameBoard[2, 0] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }
                                case 8:
                                    if (gameBoard[2, 1] != 'X' && gameBoard[2, 1] != 'O')
                                    {
                                        gameBoard[2, 1] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }
                                case 9:
                                    if (gameBoard[2, 2] != 'X' && gameBoard[2, 2] != 'O')
                                    {
                                        gameBoard[2, 2] = playerSymbol;
                                        break;
                                    }
                                    else
                                    {
                                        WrongInput();
                                        i = 1;
                                        break;
                                    }
                            }
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            DrawTable();
                            Console.WriteLine("Please, choose a free field, from numbers 1 to 9:");
                            i = 1;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        DrawTable();
                        Console.WriteLine("Please, choose a free field, from numbers 1 to 9:");
                        i = 1;
                    }
                }
                while (i == 1);
            }
            Console.WriteLine("    ");
            Console.WriteLine("THIS GAME WAS A DRAW!");
            Console.WriteLine("    ");
            Console.ReadKey();
            Console.WriteLine("Press any key to restart");
            Console.ReadKey();
            Main();
        }

        //Shows the intro screen
        public static void DrawTitleScreen()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ");
            Console.WriteLine("       ,-,---.                     .       ");
            Console.WriteLine("       ' |___/ ,-. ,-. . ,-. ,-. ,-| , ,-. ");
            Console.WriteLine("       , |   | ,-| |   | ,-| | | | |   `-. ");
            Console.WriteLine("       `-^---' `-^ '   ' `-^ ' ' `-'   `-' ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine(" ,--,--'         ,--,--'           ,--,--'         ");
            Console.WriteLine(" `- |   . ,-.    `- |   ,-. ,-.    `- |   ,-. ,-.  ");
            Console.WriteLine("  , |   | |       , |   ,-| |       , |   | | |-'  ");
            Console.WriteLine("  `-'   ' `-'     `-'   `-^ `-'     `-'   `-' `-'  ");
            Console.WriteLine("                                                     ");
            Console.WriteLine("                                                     ");
            Thread.Sleep(3000);
            Console.WriteLine("              PRESS ANY KEY TO START              ");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
        }

        //Draws the board
        public static void DrawTable()
        {
            Console.Clear();
            Console.WriteLine
            (
            " _______________________ \n" +
            "|       |       |       |\n" +
            "|   {0}   |   {1}   |   {2}   |\n" +
            "|_______|_______|_______|\n" +
            "|       |       |       |\n" +
            "|   {3}   |   {4}   |   {5}   |\n" +
            "|_______|_______|_______|\n" +
            "|       |       |       |\n" +
            "|   {6}   |   {7}   |   {8}   |\n" +
            "|_______|_______|_______|\n" +
            "\n " +
            "\n ", gameBoard[0, 0], gameBoard[0, 1], gameBoard[0, 2], gameBoard[1, 0], gameBoard[1, 1],
                   gameBoard[1, 2], gameBoard[2, 0], gameBoard[2, 1], gameBoard[2, 2]);
        }

        public static void WrongInput()
        {
            Console.Clear();
            DrawTable();
            Console.WriteLine("You can only choose empty cells. Please, try again.");
        }

        //Resets the board and the turn counter
        public static void Reset()
        {
            gameBoard[0, 0] = '1';
            gameBoard[0, 1] = '2';
            gameBoard[0, 2] = '3';
            gameBoard[1, 0] = '4';
            gameBoard[1, 1] = '5';
            gameBoard[1, 2] = '6';
            gameBoard[2, 0] = '7';
            gameBoard[2, 1] = '8';
            gameBoard[2, 2] = '9';
            turnCounter = 0;
        }
    }
}
