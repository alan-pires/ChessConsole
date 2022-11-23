using System;
using GameBoard;

namespace ChessLayer
{
    class ChessMatch
    {
        public Board board { get; private set; };
        private int turn;
        private PieceColor currentPlayer;

        public ChessMatch()
        {
            board = new Board(8, 8);
            turn = 1;
            currentPlayer = PieceColor.White;
            initializePieces();
        }

        private void initializePieces()
        {
            board.putPiece(new Tower(PieceColor.Black, board), new ChessPosition('a', 8).convertToPosition());
            board.putPiece(new Tower(PieceColor.Black, board), new ChessPosition('b', 8).convertToPosition());
            board.putPiece(new King(PieceColor.Black, board), new ChessPosition('c', 7).convertToPosition());

            board.putPiece(new King(PieceColor.White, board), new ChessPosition('c', 1).convertToPosition());
            board.putPiece(new Tower(PieceColor.White, board), new ChessPosition('c', 2).convertToPosition());
        }

        public void movePiece(Position origin, Position destiny)
        {
            Piece piece = board.takePiece(origin);
            piece.incrementMovement();
            Piece takenPiece = board.takePiece(destiny);
            board.putPiece(piece, destiny);
        }

    }
}
