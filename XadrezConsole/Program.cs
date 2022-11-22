using GameBoard;
using System;
using ChessLayer;
using BoardLayer;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board BoardGame = new Board(8, 8);
                BoardGame.putPiece(new Tower(PieceColor.Black, BoardGame), new Position(8, 8));
                BoardGame.putPiece(new Tower(PieceColor.Black, BoardGame), new Position(1, 3));
                BoardGame.putPiece(new King(PieceColor.Black, BoardGame), new Position(0, 0));
                Screen.printBoard(BoardGame);
                Console.ReadLine();
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }       
    }
}
