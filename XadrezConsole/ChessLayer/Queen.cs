using GameBoard;

namespace ChessLayer
{
    class Queen : Piece
    {
        public Queen(PieceColor color, Board board) : base(color, board) { }
        public override string ToString()
        {
            return "Q";
        }
    }
}
