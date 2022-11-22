
namespace GameBoard
{
    class Piece
    {
        public Position Pos { get; set; }
        public PieceColor Color { get; protected set; }
        public int MovesQtt { get; protected set; }
        public Board GameBoard { get; protected set; }

        public Piece(PieceColor color, Board gameBoard)
        {
            Pos = null;
            Color = color;
            GameBoard = gameBoard;
            MovesQtt = 0;
        }
    }
}
