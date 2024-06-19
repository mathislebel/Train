using System;

class Morpion
{
    static char[,] gameBoard = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
    static char currentPlayer = 'X';

    static void Main()
    {
        int moves = 0;
        bool isGameEnd = false;

        Console.WriteLine("Bienvenue dans le jeu de morpion");
        Console.WriteLine("Joueur 1 est X et Joueur 2 est O\n");

        while (!isGameEnd)
        {
            DisplayBoard();
            PlayerTurn();
            isGameEnd = CheckWin();
            if (isGameEnd)
            {
                DisplayBoard();
                Console.WriteLine($"Le joueur {currentPlayer} a gagné!");
            }
            else if (moves == 9)
            {
                DisplayBoard();
                Console.WriteLine("Match nul!");
                isGameEnd = true;
            }
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            moves++;
        }
    }

    static void DisplayBoard()
    {
        Console.WriteLine($" {gameBoard[0, 0]} | {gameBoard[0, 1]} | {gameBoard[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {gameBoard[1, 0]} | {gameBoard[1, 1]} | {gameBoard[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {gameBoard[2, 0]} | {gameBoard[2, 1]} | {gameBoard[2, 2]} \n");
    }

    static void PlayerTurn()
    {
        Console.WriteLine($"C'est le tour du joueur {currentPlayer}. Choisissez une position:");
        string input = Console.ReadLine();
        int position = int.Parse(input) - 1;
        int row = position / 3;
        int col = position % 3;

        if (gameBoard[row, col] != 'X' && gameBoard[row, col] != 'O')
        {
            gameBoard[row, col] = currentPlayer;
        }
        else
        {
            Console.WriteLine("Position déjà prise, essayez à nouveau.");
            PlayerTurn();
        }
    }

    static bool CheckWin()
    {
        for (int i = 0; i < 3; i++)
        {
          
            if (gameBoard[i, 0] == currentPlayer && gameBoard[i, 1] == currentPlayer && gameBoard[i, 2] == currentPlayer)
                return true;
        
            if (gameBoard[0, i] == currentPlayer && gameBoard[1, i] == currentPlayer && gameBoard[2, i] == currentPlayer)
                return true;
        }
        
        if (gameBoard[0, 0] == currentPlayer && gameBoard[1, 1] == currentPlayer && gameBoard[2, 2] == currentPlayer)
            return true;
        if (gameBoard[0, 2] == currentPlayer && gameBoard[1, 1] == currentPlayer && gameBoard[2, 0] == currentPlayer)
            return true;

        return false;
    }
}