using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public abstract class Piece
    {
        protected Piece(Player player)
        {
            Player = player;
        }

        public Player Player { get; private set; }

        public abstract IEnumerable<Square> GetAvailableMoves(Board board);

        public void MoveTo(Board board, Square newSquare)
        {
            var currentSquare = board.FindPiece(this);
            board.MovePiece(currentSquare, newSquare);
        }

        public IEnumerable<Square> GetRook(Board board)
        {
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            for (int i = 0; i < 8; i++)
            {
                if (i != currentPosition.Row)
                {
                    availableSquares.Add(Square.At(i, currentPosition.Col));
                }
                if (i != currentPosition.Col)
                {
                    availableSquares.Add(Square.At(currentPosition.Row, i));
                }
            }
            return availableSquares;
        }

        public IEnumerable<Square> GetBishop(Board board)
        {
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            int x = currentPosition.Row;
            int y = currentPosition.Col;

            for (int i = 1; i < 8; i++)
            {
                if (x - i >= 0)
                {
                    if (y - i >= 0)
                    {
                        availableSquares.Add(Square.At(x - i, y - i));
                    }
                    if (y + i <= 7)
                    {
                        availableSquares.Add(Square.At(x - i, y + i));
                    }
                }
                if (x + i <= 7)
                {
                    if (y - i >= 0)
                    {
                        availableSquares.Add(Square.At(x + i, y - i));
                    }
                    if (y + i <= 7)
                    {
                        availableSquares.Add(Square.At(x + i, y + i));
                    }
                }
            }

            return availableSquares;
        }
    }
}