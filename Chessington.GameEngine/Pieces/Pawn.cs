using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            int whiteStart = 7;
            int blackStart = 1;
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            if (Player == Player.White)
            {
                availableSquares.Add(Square.At(currentPosition.Row - 1, currentPosition.Col));
                if (currentPosition.Row == whiteStart)
                {
                    availableSquares.Add(Square.At(currentPosition.Row - 2, currentPosition.Col));
                }
                
            }
            else if (Player == Player.Black)
            {
                availableSquares.Add(Square.At(currentPosition.Row + 1, currentPosition.Col));
                if (currentPosition.Row == blackStart)
                {
                    availableSquares.Add(Square.At(currentPosition.Row + 2, currentPosition.Col));
                }
            }

            return availableSquares;
        }
    }
}