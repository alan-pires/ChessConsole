
using GameBoard;

namespace ChessConsole
{
    class Screen
    {
        public static void printBoard(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.getPiece(i, j) == null)
                        Console.Write("- ");
                    else
                        Console.Write(board.getPiece(i, j) +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
