using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[] boardArr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int output; //Checks what number (-1 = Draw , 1 = Wim) CheckWin Returns

        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); //Clear Board
                Console.WriteLine("Player 1 - X \nPlayer 2 - O");
                Board();
                
                int choice = int.Parse(Console.ReadLine()); //Converts the string value into the int value

                if (boardArr[choice] != 'X' && boardArr[choice] != 'O') //If there isnt an X or O  at that spot
                {
                    if (player % 2 == 0)
                    {
                        boardArr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        boardArr[choice] = 'X';
                        player++;
                    }
                } else
                {
                    Console.WriteLine("Spot is already marked with {0}", boardArr[choice]);
                }
                output = CheckWin();

            } while (output != 1 && output != -1);
            
            if (output == 1)
            {
                Console.WriteLine("Player {0} has won", player % 2 + 1);
            }

            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
    

        //Create the Board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", boardArr[1], boardArr[2], boardArr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", boardArr[4], boardArr[5], boardArr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", boardArr[7], boardArr[8], boardArr[9]);

            Console.WriteLine("     |     |      ");

        }

        private static int CheckWin()
        {
            #region Horizontal Wins
            if (boardArr[1] == boardArr[2] && boardArr[2] == boardArr[3])
            {
                return 1;
            }
            else if (boardArr[4] == boardArr[5] && boardArr[5] == boardArr[6])
            {
                return 1;
            }
            else if (boardArr[7] == boardArr[8] && boardArr[8] == boardArr[9])
            {
                return 1;
            }
            #endregion
            #region Vertical Wins
            else if (boardArr[1] == boardArr[4] && boardArr[4] == boardArr[7])
            {
                return 1;
            }
            else if (boardArr[2] == boardArr[5] && boardArr[5] == boardArr[8])
            {
                return 1;
            }
            else if (boardArr[3] == boardArr[6] && boardArr[6] == boardArr[9])
            {
                return 1;
            }
            #endregion
            #region Oblique Wins
            else if (boardArr[1] == boardArr[5] && boardArr[5] == boardArr[9])
            {
                return 1;
            }
            else if (boardArr[3] == boardArr[5] && boardArr[5] == boardArr[7])
            {
                return 1;
            }
            #endregion
            #region Check for Draw
            else if (boardArr[1] != '1' && boardArr[2] != '2' && boardArr[3] != '3' && boardArr[4] != '4' && boardArr[5] != '5' && 
                boardArr[6] != '6' && boardArr[7] != '7' && boardArr[8] != '8' && boardArr[9] != '9')
            {
                return -1;
            }
            #endregion
            else 
            {
                return 0;
            }
        }
    }
}
