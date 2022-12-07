
using GameBoard;

namespace ChessLayer
{
    class knight : Piece
    {
        public knight(PieceColor color, Board board) : base(color, board){ }
        public override string ToString()
        {
            return "H"; // Horse instead of Knight :(
        }
    }
}
