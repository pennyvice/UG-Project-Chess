

namespace Chess_Logics
{
    public  class Queen : Piece
    {
        public override PieceType Type => PieceType.Queen;
        public override Player Color { get; }

        private static readonly Direction[] dirs = new Direction[]
    {
            Direction.NorthEast,
            Direction.NorthWest, Direction.SouthEast, Direction.SouthWest,
            Direction.North,Direction.South, Direction.East,Direction.West
    };


        public Queen(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Queen copy = new Queen(Color);
            copy.Hasmoved = Hasmoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMoves(from, to));
        }
    }
}
