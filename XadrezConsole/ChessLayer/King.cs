using GameBoard;

namespace ChessLayer
{
    class King : Piece
    {
        public  King(PieceColor color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
