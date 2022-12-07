using GameBoard;

namespace ChessLayer
{
    class Bishop : Piece
    {
        public Bishop(PieceColor color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
