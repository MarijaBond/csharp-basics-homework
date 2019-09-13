using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
        }

        private static void InitBoard()
        {
            Console.WriteLine("Players, get Ready! The Game is about to start!");
            DisplayBoard();

            int stopCondition = 0;

            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }

            Console.WriteLine("Player ZERO, pick your coordinates!"); //  1st 
            string picksZero = (Console.ReadLine());
            int[] zeroArray = new int[2];
            zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
            zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
            Console.WriteLine("My 1st test array is printed out: " + string.Join(",", zeroArray));
            board[zeroArray[0], zeroArray[1]] = '0';
            DisplayBoard();


            Console.WriteLine("Player X, pick your coordinates!"); //2nd
            string picksX = (Console.ReadLine());
            int[] xArray = new int[2];
            xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
            xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
            if (board[xArray[0], xArray[1]] == ' ')
            {
                board[xArray[0], xArray[1]] = 'X';
                DisplayBoard();
            }
            else
            {
                Console.WriteLine("This position is already taken! Try another one!!!");
                picksX = (Console.ReadLine());
                xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                if (board[xArray[0], xArray[1]] == ' ')
                {
                    board[xArray[0], xArray[1]] = 'X';
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("This position is already taken! Try another one!!!");
                    picksX = (Console.ReadLine());
                    xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                    xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                    if (board[xArray[0], xArray[1]] == ' ')
                    {
                        board[xArray[0], xArray[1]] = 'X';
                        DisplayBoard();
                    }
                    else
                    {
                        Console.WriteLine(
                            "Oooopsie! You made a mistake 3 times in a row. Seems like you're not smart enough for this game. The game is over!");

                        stopCondition++;
                    }
                }
            }

            if (stopCondition == 0)
            {
                Console.WriteLine("Player ZERO, pick your coordinates!"); //3rd
                picksZero = (Console.ReadLine());
                zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                if (board[zeroArray[0], zeroArray[1]] == ' ')
                {
                    board[zeroArray[0], zeroArray[1]] = '0';
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("This position is already taken! Try another one!!!");
                    picksZero = (Console.ReadLine());
                    zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                    zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                    if (board[zeroArray[0], zeroArray[1]] == ' ')
                    {
                        board[zeroArray[0], zeroArray[1]] = '0';
                        DisplayBoard();
                    }
                    else
                    {
                        Console.WriteLine("This position is already taken! Try another one!!!");
                        picksZero = (Console.ReadLine());
                        zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                        zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                        if (board[zeroArray[0], zeroArray[1]] == ' ')
                        {
                            board[zeroArray[0], zeroArray[1]] = '0';
                            DisplayBoard();
                        }
                        else
                        {
                            Console.WriteLine(
                                "Oooopsie! You made a mistake 3 times in a row. Seems like you're not smart enough for this game. The game is over!");

                            stopCondition++;
                        }
                    }
                }
            }

            if (stopCondition == 0)
            {
                Console.WriteLine("Player X, pick your coordinates!"); //4th
                picksX = (Console.ReadLine());
                xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                if (board[xArray[0], xArray[1]] == ' ')
                {
                    board[xArray[0], xArray[1]] = 'X';
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("This position is already taken! Try another one!!!");
                    picksX = (Console.ReadLine());
                    xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                    xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                    if (board[xArray[0], xArray[1]] == ' ')
                    {
                        board[xArray[0], xArray[1]] = 'X';
                        DisplayBoard();
                    }
                    else
                    {
                        Console.WriteLine("This position is already taken! Try another one!!!");
                        picksX = (Console.ReadLine());
                        xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                        xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                        if (board[xArray[0], xArray[1]] == ' ')
                        {
                            board[xArray[0], xArray[1]] = 'X';
                            DisplayBoard();
                        }
                        else
                        {
                            Console.WriteLine(
                                "Oooopsie! You made a mistake 3 times in a row. Seems like you're not smart enough for this game. The game is over!");

                            stopCondition++;
                        }
                    }
                }
            }

            if (stopCondition == 0)
            {
                Console.WriteLine("Player ZERO, pick your coordinates!"); //5th
                picksZero = (Console.ReadLine());
                zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                if (board[zeroArray[0], zeroArray[1]] == ' ')
                {
                    board[zeroArray[0], zeroArray[1]] = '0';
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("This position is already taken! Try another one!!!");
                    picksZero = (Console.ReadLine());
                    zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                    zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                    if (board[zeroArray[0], zeroArray[1]] == ' ')
                    {
                        board[zeroArray[0], zeroArray[1]] = '0';
                        DisplayBoard();
                    }
                    else
                    {
                        Console.WriteLine("This position is already taken! Try another one!!!");
                        picksZero = (Console.ReadLine());
                        zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                        zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                        if (board[zeroArray[0], zeroArray[1]] == ' ')
                        {
                            board[zeroArray[0], zeroArray[1]] = '0';
                            DisplayBoard();
                        }
                        else
                        {
                            Console.WriteLine(
                                "Oooopsie! You made a mistake 3 times in a row. Seems like you're not smart enough for this game. The game is over!");

                            stopCondition++;
                        }
                    }
                }
                if (CheckWinner())
                {
                    Console.WriteLine("Congratulations to Player ZERO! \n You WON!!!");
                }
            }

            

            if (stopCondition == 0 && !CheckWinner())
            {
                Console.WriteLine("Player X, pick your coordinates!"); //6th
                picksX = (Console.ReadLine());
                xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                if (board[xArray[0], xArray[1]] == ' ')
                {
                    board[xArray[0], xArray[1]] = 'X';
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("This position is already taken! Try another one!!!");
                    picksX = (Console.ReadLine());
                    xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                    xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                    if (board[xArray[0], xArray[1]] == ' ')
                    {
                        board[xArray[0], xArray[1]] = 'X';
                        DisplayBoard();
                    }
                    else
                    {
                        Console.WriteLine("This position is already taken! Try another one!!!");
                        picksX = (Console.ReadLine());
                        xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                        xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                        if (board[xArray[0], xArray[1]] == ' ')
                        {
                            board[xArray[0], xArray[1]] = 'X';
                            DisplayBoard();
                        }
                        else
                        {
                            Console.WriteLine(
                                "Oooopsie! You made a mistake 3 times in a row. Seems like you're not smart enough for this game. The game is over!");

                            stopCondition++;
                        }
                    }
                }
                if (CheckWinner())
                {
                    Console.WriteLine("Congratulations to Player X! \n You WON!!!");
                }
            }

            

            if (stopCondition == 0 && !CheckWinner())
            {
                Console.WriteLine("Player ZERO, pick your coordinates!"); //7th
                picksZero = (Console.ReadLine());
                zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                if (board[zeroArray[0], zeroArray[1]] == ' ')
                {
                    board[zeroArray[0], zeroArray[1]] = '0';
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("This position is already taken! Try another one!!!");
                    picksZero = (Console.ReadLine());
                    zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                    zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                    if (board[zeroArray[0], zeroArray[1]] == ' ')
                    {
                        board[zeroArray[0], zeroArray[1]] = '0';
                        DisplayBoard();
                    }
                    else
                    {
                        Console.WriteLine("This position is already taken! Try another one!!!");
                        picksZero = (Console.ReadLine());
                        zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                        zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                        if (board[zeroArray[0], zeroArray[1]] == ' ')
                        {
                            board[zeroArray[0], zeroArray[1]] = '0';
                            DisplayBoard();
                        }
                        else
                        {
                            Console.WriteLine(
                                "Oooopsie! You made a mistake 3 times in a row. Seems like you're not smart enough for this game. The game is over!");

                            stopCondition++;
                        }
                    }
                }
                if (CheckWinner())
                {
                    Console.WriteLine("Congratulations to Player ZERO! \n You WON!!!");
                }
            }
            

            if (stopCondition == 0 && !CheckWinner())
            {
                Console.WriteLine("Player X, pick your coordinates!"); //8th
                picksX = (Console.ReadLine());
                xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                if (board[xArray[0], xArray[1]] == ' ')
                {
                    board[xArray[0], xArray[1]] = 'X';
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("This position is already taken! Try another one!!!");
                    picksX = (Console.ReadLine());
                    xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                    xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                    if (board[xArray[0], xArray[1]] == ' ')
                    {
                        board[xArray[0], xArray[1]] = 'X';
                        DisplayBoard();
                    }
                    else
                    {
                        Console.WriteLine("This position is already taken! Try another one!!!");
                        picksX = (Console.ReadLine());
                        xArray[0] = Convert.ToInt32(picksX.Split(',')[0]);
                        xArray[1] = Convert.ToInt32(picksX.Split(',')[1]);
                        if (board[xArray[0], xArray[1]] == ' ')
                        {
                            board[xArray[0], xArray[1]] = 'X';
                            DisplayBoard();
                        }
                        else
                        {
                            Console.WriteLine(
                                "Oooopsie! You made a mistake 3 times in a row. Seems like you're not smart enough for this game. The game is over!");

                            stopCondition++;
                        }
                    }
                }
                if (CheckWinner())
                {
                    Console.WriteLine("Congratulations to Player X! \n You WON!!!");
                }
            }

         

            if (stopCondition == 0 && !CheckWinner())
            {
                Console.WriteLine("Player ZERO, pick your coordinates!"); //9th
                picksZero = (Console.ReadLine());
                zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                if (board[zeroArray[0], zeroArray[1]] == ' ')
                {
                    board[zeroArray[0], zeroArray[1]] = '0';
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("This position is already taken! Try another one!!!");
                    picksZero = (Console.ReadLine());
                    zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                    zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                    if (board[zeroArray[0], zeroArray[1]] == ' ')
                    {
                        board[zeroArray[0], zeroArray[1]] = '0';
                        DisplayBoard();
                    }
                    else
                    {
                        Console.WriteLine("This position is already taken! Try another one!!!");
                        picksZero = (Console.ReadLine());
                        zeroArray[0] = Convert.ToInt32(picksZero.Split(',')[0]);
                        zeroArray[1] = Convert.ToInt32(picksZero.Split(',')[1]);
                        if (board[zeroArray[0], zeroArray[1]] == ' ')
                        {
                            board[zeroArray[0], zeroArray[1]] = '0';
                            DisplayBoard();
                        }
                        else
                        {
                            Console.WriteLine(
                                "Oooopsie! You made a mistake 3 times in a row. Seems like you're not smart enough for this game. The game is over!");

                            stopCondition++;
                        }

                    }
                    if (CheckWinner())
                    {
                        Console.WriteLine("Congratulations to Player ZERO! \n You WON!!!");
                    }
                }
            }
        }


        static bool CheckWinner()
        {
            if (board[0, 0] == '0' && board[0, 1] == '0' && board[0, 2] == '0') // Horizontal (O)
            {
                return true;
            }
            else if (board[1, 0] == '0' && board[1, 1] == '0' && board[1, 2] == '0')
            {
                return true;
            }
            else if (board[2, 0] == '0' && board[2, 1] == '0' && board[2, 2] == '0')
            {
                return true;
            }
            else if (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X') // Horizontal (X)
            {
                return true;
            }
            else if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
            {
                return true;
            }
            else if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }

            else if (board[0, 0] == '0' && board[1, 0] == '0' && board[2, 0] == '0') // Vertical (O)
            {
                return true;
            }
            else if (board[0, 1] == '0' && board[1, 1] == '0' && board[2, 1] == '0')
            {
                return true;
            }
            else if (board[0, 2] == '0' && board[1, 2] == '0' && board[2, 2] == '0')
            {
                return true;
            }
            else if (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X') // Vertical (X)
            {
                return true;
            }
            else if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
            {
                return true;
            }
            else if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            else if (board[0, 0] == '0' && board[1, 1] == '0' && board[2, 2] == '0') // Diagonal (O)
            {
                return true;
            }
            else if (board[0, 2] == '0' && board[1, 1] == '0' && board[2, 0] == '0')
            {
                return true;
            }
            else if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X') // Diagonal (X)
            {
                return true;
            }
            else if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
            {
                return true;
            }

            else // No winner 
            {
                return false;
            }
        }
    
    private static void DisplayBoard()
            {
                Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
                Console.WriteLine("    --+-+--");
                Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
                Console.WriteLine("    --+-+--");
                Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
                Console.WriteLine("    --+-+--");
            }
        }
    }

