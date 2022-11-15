
namespace GameBoard
{
    class Piece
    {
        public Position Pos { get; set; }
        public PieceColor Color { get; protected set; }
        public int MovesQtt { get; protected set; }
        public Board GameBoard { get; protected set; }

        public Piece(Position pos, PieceColor color, Board gameBoard)
        {
            Pos = pos;
            Color = color;
            GameBoard = gameBoard;
            MovesQtt = 0;
        }
    }
}
