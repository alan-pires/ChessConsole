using GameBoard;

namespace ChessLayer
{
    class Tower : Piece 
    {
        public Tower(PieceColor color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
