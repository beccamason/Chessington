using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
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