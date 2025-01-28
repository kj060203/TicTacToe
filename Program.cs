// The “Driver” class (the Program.cs class with the main method where the program begins) will:
// Welcome the user to the game
// Create a game board array to store the players’ choices
// Ask each player in turn for their choice and update the game board array
// Print the board by calling the method in the supporting class
// Check for a winner by calling the method in the supporting class, and notify the players
// when a win has occurred and which player won the game


using TicTacToe;

Methods mt = new Methods();
// Initialize Variables 
char[,] gameBoard = new char[3, 3];
bool player = true;
char player1 = 'X';
char player2 = 'O';
int row = 0;
int column = 0;
bool isValid = false;
bool gameOver = false;

// Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");


do
{
    // Selects a player and gets input from the player 
    if (player)
    {
        while (!isValid)
        {
            Console.WriteLine("Player 1, you are X. Enter which row you would like to select (1-3): ");
            row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter which column you would like to select (1-3): ");
            column = Convert.ToInt32(Console.ReadLine());

            // Validates if the space is already taken
            if (!string.IsNullOrEmpty(gameBoard[(row - 1), (column - 1)]))
            {
                Console.WriteLine("That space is already taken. Please select another space.");
            }
            else
            {
                gameBoard[(row - 1), (column - 1)] = player1;
                if (mt.checkWinner(gameBoard) != 0)
                {
                    Console.WriteLine($"Player {mt.checkWinner} Wins!!!");
                    gameOver = true;
                }
                else if (mt.checkWinner(gameBoard) == 0)
                {
                    gameOver = true;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (gameBoard[i, j] == null)
                            {
                                gameOver = false;
                            }
                        }
                    }
                    if (gameOver)
                    {
                        Console.WriteLine("It's a Tie!!");
                    }

                    isValid = true;
                }

               mt.printBoard(gameBoard);


                player = !player;
            }
        }
    }
    //Same logic as the player 1 input
    else if (!player)
    {
        while (!isValid)
        {
            Console.WriteLine("Player 2, you are O. Enter which row you would like to select (1-3): ");
            row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter which column you would like to select (1-3): ");
            column = Convert.ToInt32(Console.ReadLine());

            gameBoard[(row - 1), (column - 1)] = player1;

            // Validates if the space is already taken
            if (!string.IsNullOrEmpty(gameBoard[(row - 1), (column - 1)]))
            {
                Console.WriteLine("That space is already taken. Please select another space.");
            }
            else
            {
                gameBoard[(row - 1), (column - 1)] = player2;
                if (mt.checkWinner(gameBoard) != 0)
                {
                    Console.WriteLine($"Player {mt.checkWinner} Wins!!!");
                    gameOver = true;
                }
                else if (mt.checkWinner(gameBoard) == 0)
                {
                    gameOver = true;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (gameBoard[i, j] == null)
                            {
                                gameOver = false;
                            }
                        }
                    }
                    if (gameOver)
                    {
                        Console.WriteLine("It's a Tie!!");
                    }

                    isValid = true;
                }

                mt.printBoard(gameBoard);


                player = !player;
            }
        }
    }
}
while (!gameOver);





