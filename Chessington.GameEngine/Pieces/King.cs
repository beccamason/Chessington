using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            int x = currentPosition.Row;
            int y = currentPosition.Col;

            if (x + 1 <= 7)
            {
                availableSquares.Add(Square.At(x + 1, y));
                if (y + 1 <= 7)
                {
                    availableSquares.Add(Square.At(x + 1, y + 1));
                }
                if (y - 1 >= 0)
                {
                    availableSquares.Add(Square.At(x + 1, y - 1));
                }
            }
            if (x - 1 >= 0)
            {
                availableSquares.Add(Square.At(x - 1, y));
                if (y + 1 <= 7)
                {
                    availableSquares.Add(Square.At(x - 1, y + 1));
                }
                if (y - 1 >= 0)
                {
                    availableSquares.Add(Square.At(x - 1, y - 1));
                }
            }
            if (y + 1 <= 7)
            {
                availableSquares.Add(Square.At(x, y + 1));
            }
            if (y - 1 >= 0)
            {
                availableSquares.Add(Square.At(x, y - 1));
            }        

            return availableSquares;
        }
    }
}