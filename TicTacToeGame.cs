using System;
namespace TicTacToe
{
    public class TicTacToeGame
    {

        int result = 0;
        string player = "x";
        int markinrow = "-";
        public Array board
        ;

        public void createBoard()
        {
            board = new Array[9];
        }

        public String currentPlayer()
        {
            return player;
        }

        public void changePlayer()
        {
            if (player == "x")
            {
                player = "o";
            }
            else
            {
                player = "x";
            }

        }

        public string makemove(Array board)
        {
            while (board.markirow() < 3 && !board.isFull())
            {
                player().makemove();
            }
        }

        public void spaceinuse(board, move)
        {
            return board[move] == '-';
        }
    }
}