namespace TicTacToe
{
    internal class Methods
    {
        // Prints the board in a 3x3 format
        public static void printBoard(string[] board)
        {
            Console.WriteLine("\n");
            Console.WriteLine($" {board[0] ?? " "} | {board[1] ?? " "} | {board[2] ?? " "} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3] ?? " "} | {board[4] ?? " "} | {board[5] ?? " "} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6] ?? " "} | {board[7] ?? " "} | {board[8] ?? " "} ");
            Console.WriteLine("\n");
        }

        // Checks for a winner and returns the winning player number or "0" for no winner
        public static string checkWinner(string[] board)
        {
            // Winning combinations
            int[,] winningPositions = {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Rows
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columns
                { 0, 4, 8 }, { 2, 4, 6 }              // Diagonals
            };

            for (int i = 0; i < winningPositions.GetLength(0); i++)
            {
                int a = winningPositions[i, 0];
                int b = winningPositions[i, 1];
                int c = winningPositions[i, 2];

                if (board[a] == board[b] && board[b] == board[c] && !string.IsNullOrEmpty(board[a]))
                {
                    return board[a] == "X" ? "1" : "2";
                }
            }

            return "0"; // No winner
        }
    }
}
