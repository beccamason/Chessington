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
            int whiteStart = 6;
            int blackStart = 1;
            Square currentPosition = board.FindPiece(this);
            var availableSquares = new List<Square>();

            int x = currentPosition.Row;
            int y = currentPosition.Col;

            

            if (Player == Player.White)
            {
                if (Square.At(x - 1, y) == null)
                {
                    availableSquares.Add(Square.At(currentPosition.Row - 1, currentPosition.Col));
                    if (currentPosition.Row == whiteStart && Square.At(x - 2, y) == null)
                    {
                        availableSquares.Add(Square.At(currentPosition.Row - 2, currentPosition.Col));
                    }
                }
            }
            else if (Player == Player.Black)
            {
                if (Square.At(x + 1, y) == null)
                { 
                    availableSquares.Add(Square.At(currentPosition.Row + 1, currentPosition.Col));
                    if (currentPosition.Row == blackStart && Square.At(x+2, y) == null)
                    {
                        availableSquares.Add(Square.At(currentPosition.Row + 2, currentPosition.Col));
                    }
                }
            }

            return availableSquares;
        }
    }
}