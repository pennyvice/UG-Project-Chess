

namespace Chess_Logics
{
    public  class Bishop : Piece
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Color { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.NorthEast,
            Direction.NorthWest, Direction.SouthEast, Direction.SouthWest
        };



        public Bishop(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Bishop copy = new Bishop(Color);
            copy.Hasmoved = Hasmoved;
            return copy;
        }


        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select (to => new NormalMoves(from, to ));
        }
    }
}
