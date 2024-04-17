
namespace Chess_Logics
{
    public  class Rook : Piece
    {
        public override PieceType Type => PieceType.Rook;
        public override Player Color { get; }


        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.North, Direction.South, Direction.East, Direction.West
        };

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMoves(from, to));
        }

        public Rook(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Rook copy = new Rook(Color);
            copy.Hasmoved = Hasmoved;
            return copy;
        }
    }
}
