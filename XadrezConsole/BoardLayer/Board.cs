
using BoardLayer;
using System.Runtime.InteropServices;

namespace GameBoard
{  
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] pieces;

        public Board(int lines, int columns)   
        {
            Lines = lines;
            Columns = columns;
            pieces = new Piece[Lines, Columns];
        }

        public Piece getPiece(int line, int column)
        {
            return pieces[line, column];
        }

        public Piece getPiece(Position pos)
        {
            return pieces[pos.Line, pos.Column];
        }

        public bool havePieceAt(Position pos)
        {
            validatePosition(pos);
            return getPiece(pos) != null;
        }

        public void putPiece(Piece piece, Position pos)
        {
            if (havePieceAt(pos))
                throw new BoardException("There is already a piece at this position");
            pieces[pos.Line, pos.Column] = piece;
            piece.Pos = pos;
        }

        public bool isValidePosition(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
                return false;
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!isValidePosition(pos))
                throw new BoardException("Invalid Position");
        }
    }
}
