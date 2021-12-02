using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var a = GetBishop(board);
            var b = GetRook(board);
            var availableSquares = a.Concat(b);

            return availableSquares;
        }
    }
}