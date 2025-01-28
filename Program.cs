using TicTacToe;

// Initialize Variables 
string[] gameBoard = new string[9];
bool player = true; 
string player1 = "X";
string player2 = "O";
int row = 0;
int column = 0;
bool isValid = false;
bool gameOver = false;

// Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

do
{
    // Selects a player and gets their input
    if (player)
    {
        isValid = false;
        while (!isValid)
        {
            Console.WriteLine("Player 1, you are X. Enter which row you would like to select (1-3): ");
            row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter which column you would like to select (1-3): ");
            column = Convert.ToInt32(Console.ReadLine());

            // Uses index to place guess correctly on the board
            int index = (row - 1) * 3 + (column - 1);

            // Validate if the space is already taken
            if (!string.IsNullOrEmpty(gameBoard[index]))
            {
                Console.WriteLine("That space is already taken. Please select another space.");
            }
            else
            {
                gameBoard[index] = player1;
                //Checking to see if the game is over. If over it will print who won or if it is a tie. Else it will continue
                if (mt.checkWinner(gameBoard) != "0")
                {
                    Console.WriteLine($"Player {Methods.checkWinner(gameBoard)} Wins!!!");
                    gameOver = true;
                }
                else if (!gameBoard.Contains(null))
                {
                    Console.WriteLine("It's a Tie!!");
                    gameOver = true;
                }

                mt.printBoard(gameBoard);
                isValid = true;
                player = !player;
            }
        }
    }
    else
    {
        isValid = false;
        while (!isValid)
        {
            Console.WriteLine("Player 2, you are O. Enter which row you would like to select (1-3): ");
            row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter which column you would like to select (1-3): ");
            column = Convert.ToInt32(Console.ReadLine());

            
            int index = (row - 1) * 3 + (column - 1);

            // Validate if the space is already taken
            if (!string.IsNullOrEmpty(gameBoard[index]))
            {
                Console.WriteLine("That space is already taken. Please select another space.");
            }
            else
            {
                gameBoard[index] = player2;
                if (mt.checkWinner(gameBoard) != "0")
                {
                    Console.WriteLine($"Player {Methods.checkWinner(gameBoard)} Wins!!!");
                    gameOver = true;
                }
                else if (!gameBoard.Contains(null))
                {
                    Console.WriteLine("It's a Tie!!");
                    gameOver = true;
                }

                mt.printBoard(gameBoard);
                isValid = true;
                player = !player;
            }
        }
    }
}
while (!gameOver);
