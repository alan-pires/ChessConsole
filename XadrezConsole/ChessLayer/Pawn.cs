
using GameBoard;

namespace ChessLayer
{
    class Pawn : Piece
    {
        public Pawn(PieceColor color, Board board) : base(color, board) { }
        public override string ToString()
        {
            return "P";
        }
    }
}
