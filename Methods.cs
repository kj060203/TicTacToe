using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//The supporting class (Methods.cs) will:
// Receive the “board” array from the driver class
// Contain a method that prints the board based on the information passed to it
// Contain a method that receives the game board array as input and returns if there is a winner and who it was

namespace TicTacToe
{
    internal class Methods
    {
        // Contain a method that prints the board based on the information passed to it
        public static void printBoard(char[] board)
        {
            Console.WriteLine("\n");
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            Console.WriteLine("\n");
        }

        // Contain a method that receives the game board array as input and returns if there is a winner and who it was
        public static string checkWinner(char[] board)
        {
            // Winning combos
            int[,] winningPositions = {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
                { 0, 4, 8 }, { 2, 4, 6 }
            };

            for (int i = 0; i < winningPositions.GetLength(0); i++)
            {
                int a = winningPositions[i, 0];
                int b = winningPositions[i, 1];
                int c = winningPositions[i, 2];

                if (board[a] == board[b] && board[b] == board[c])
                {
                    return board[a] == 'X' ? "1" : "2";
                }
            }

            return "0"; // No winner logic
        }
    }
}
