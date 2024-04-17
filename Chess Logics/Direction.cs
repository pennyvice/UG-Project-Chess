
namespace Chess_Logics
{
    public  class Direction
    {

        public readonly static Direction North = new Direction(-1, 0);
        public readonly static Direction South = new Direction(1,0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction SouthWest = South + West;

        public int Rowdelta { get; }
        public int Columndelta { get; }

        public Direction(int rowdelta, int columndelta)
        {
            Rowdelta = rowdelta;
            Columndelta = columndelta;
        }

        public static Direction operator +(Direction dir1, Direction dir2) 
        {
            return new Direction(dir1.Rowdelta + dir2.Rowdelta, dir1.Columndelta + dir2.Columndelta);
        }
        public static Direction operator *(int scalar, Direction dir)
        {
            return new Direction (scalar * dir.Rowdelta, scalar * dir.Columndelta);
        } 

    }
}
