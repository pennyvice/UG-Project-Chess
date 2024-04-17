
namespace Chess_Logics
{
    public enum Player
    {
        None,
        White,
        Black
    }

    public static class Playerextensions
    {
        public static Player opponent (this Player player)
        {
            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };
        }
    }
}
