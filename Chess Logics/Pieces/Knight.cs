using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Logics
{
    public class Knight: Piece
    {
        public override PieceType Type => PieceType.Knight;
        public override Player Color { get; }

        public Knight(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Knight copy = new Knight(Color);
            copy.Hasmoved = Hasmoved;
            return copy;
        }
    }
}
