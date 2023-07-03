﻿using System;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' },
        };

      

        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputCorrect = true;


            do
            {

              
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }

                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }

                setField();

                //check winning condition
                #region
                char[] playerChars = { 'X', 'O' };

                foreach(char playerChar in playerChars)
                {
                    if (((playField[0,0]==playerChar)&& (playField[0, 1] == playerChar)&& (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1,2 ] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))

                        )
                    {
                        if(playerChar=='X')
                        {
                            Console.WriteLine("\nPlayer2 is win (: ");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer1 is Win (:");
                        }
                        Console.WriteLine("Press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if(turns==10)
                    {
                        Console.WriteLine("\nNo Winner ):");
                        Console.WriteLine("Press enter any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                   
                }

                #endregion

                //test if field is already taken
                #region
                do
                {
                    Console.WriteLine("\nPlyer{0} choose your field!",player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");

                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true; 
                    else if((input == 2) && (playField[0,1]=='2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nIncorrect input, Please try another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion

            }
            while (true);


           
        }

        public static void ResetField()
        {
             char[,] playFieldInitial ={
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' },
        };
            playField = playFieldInitial;
            setField();
            turns = 0;

        }

       public static void setField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            turns++;
        }

        public static void EnterXorO(char playerSign,int input)
        {
        

            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign;  break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;

            }
            
        }
    }
}
