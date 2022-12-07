using System;
using GameBoard;

namespace ChessLayer
{
    class ChessMatch
    {
        public Board board { get; private set; }
        private int turn;
        private PieceColor currentPlayer;
        public bool machEnded { get; private set; }

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
            board.putPiece(new knight(PieceColor.Black, board), new ChessPosition('b', 8).convertToPosition());
            board.putPiece(new Bishop(PieceColor.Black, board), new ChessPosition('c', 8).convertToPosition());
            board.putPiece(new Queen(PieceColor.Black, board), new ChessPosition('d', 8).convertToPosition());
            board.putPiece(new King(PieceColor.Black, board), new ChessPosition('e', 8).convertToPosition());
            board.putPiece(new Bishop(PieceColor.Black, board), new ChessPosition('f', 8).convertToPosition());
            board.putPiece(new knight(PieceColor.Black, board), new ChessPosition('g', 8).convertToPosition());
            board.putPiece(new Tower(PieceColor.Black, board), new ChessPosition('h', 8).convertToPosition());
            board.putPiece(new Pawn(PieceColor.Black, board), new ChessPosition('a', 7).convertToPosition());
            board.putPiece(new Pawn(PieceColor.Black, board), new ChessPosition('b', 7).convertToPosition());
            board.putPiece(new Pawn(PieceColor.Black, board), new ChessPosition('c', 7).convertToPosition());
            board.putPiece(new Pawn(PieceColor.Black, board), new ChessPosition('d', 7).convertToPosition());
            board.putPiece(new Pawn(PieceColor.Black, board), new ChessPosition('e', 7).convertToPosition());
            board.putPiece(new Pawn(PieceColor.Black, board), new ChessPosition('f', 7).convertToPosition());
            board.putPiece(new Pawn(PieceColor.Black, board), new ChessPosition('g', 7).convertToPosition());
            board.putPiece(new Pawn(PieceColor.Black, board), new ChessPosition('h', 7).convertToPosition());

            board.putPiece(new Tower(PieceColor.White, board), new ChessPosition('a', 1).convertToPosition());
            board.putPiece(new knight(PieceColor.White, board), new ChessPosition('b', 1).convertToPosition());
            board.putPiece(new Bishop(PieceColor.White, board), new ChessPosition('c', 1).convertToPosition());
            board.putPiece(new Queen(PieceColor.White, board), new ChessPosition('d', 1).convertToPosition());
            board.putPiece(new King(PieceColor.White, board), new ChessPosition('e', 1).convertToPosition());
            board.putPiece(new Bishop(PieceColor.White, board), new ChessPosition('f', 1).convertToPosition());
            board.putPiece(new knight(PieceColor.White, board), new ChessPosition('g', 1).convertToPosition());
            board.putPiece(new Tower(PieceColor.White, board), new ChessPosition('h', 1).convertToPosition());
            board.putPiece(new Pawn(PieceColor.White, board), new ChessPosition('a', 2).convertToPosition());
            board.putPiece(new Pawn(PieceColor.White, board), new ChessPosition('b', 2).convertToPosition());
            board.putPiece(new Pawn(PieceColor.White, board), new ChessPosition('c', 2).convertToPosition());
            board.putPiece(new Pawn(PieceColor.White, board), new ChessPosition('d', 2).convertToPosition());
            board.putPiece(new Pawn(PieceColor.White, board), new ChessPosition('e', 2).convertToPosition());
            board.putPiece(new Pawn(PieceColor.White, board), new ChessPosition('f', 2).convertToPosition());
            board.putPiece(new Pawn(PieceColor.White, board), new ChessPosition('g', 2).convertToPosition());
            board.putPiece(new Pawn(PieceColor.White, board), new ChessPosition('h', 2).convertToPosition());
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
