using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Logics
{
    public class NormalMoves : Move
    {
        public override MoveType Type => MoveType.Normal;
        public override Position FromPos { get; }

        public override Position ToPos { get; }

        public NormalMoves(Position fromPos, Position toPos)
        {
            FromPos = fromPos;
            ToPos = toPos;
        }

        public override void Execute(Board board)
        {
            Piece piece = board[FromPos];
            board[ToPos] = piece;
            board[FromPos] = null;
            piece.Hasmoved = true;
        }
    }
}
