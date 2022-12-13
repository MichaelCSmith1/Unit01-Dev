using System;
using System.Collections.Generic;

namespace Cse210Prove01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> board = GetNewBoard();
            String currentPlayer = "x";
            bool gameRunning = true;
            printBoard(board);
            while (gameRunning == true)
            {
                askPlayer(currentPlayer, board);
                printBoard(board);
                checkGame(board,gameRunning,currentPlayer);
                currentPlayer = checkPlayer(currentPlayer);
            }
            Console.WriteLine("Good game thanks for playing!");
        }

        static List<string> GetNewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }
            
            return board;
        }

        static string checkPlayer(string currentPlayer)
        {
            string nextPlayer = "x";

            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }
            return nextPlayer;
            
        }

        static void askPlayer(string currentPlayer, List<string> board)
        {
            Console.WriteLine($"{currentPlayer}'s turn to choose a square(1-9): ");
            string? guess = Console.ReadLine();
            int index = int.Parse(guess);
    
            board[index-1] = currentPlayer;
        }

        static bool checkGame(List<string> board, bool gameRunning, string currentPlayer)
        {
            //Checks for game win and tie
            if ((board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer) ||
                (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer) ||
                (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer) ||
                (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) ||
                (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer) ||
                (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer) ||
                (board[1] == currentPlayer && board[5] == currentPlayer && board[7] == currentPlayer) ||
                (board[3] == currentPlayer && board[6] == currentPlayer && board[8] == currentPlayer))
            {
                gameRunning = false;
            }
            Console.WriteLine(currentPlayer);
            Console.WriteLine(gameRunning);

            return gameRunning;

        }

        static void printBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

    }
}
