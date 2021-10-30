
namespace chess.business
{
    /// <summary>
    /// Enum for the piece color
    /// </summary>
    public enum Color : byte
    {
        Black = 1,
        White = 2,
    }
    /// <summary>
    /// Enum for the piece type
    /// </summary>
    public enum Type : byte
    {
        Queen = 1,
        King = 2,
        Bishop = 3,
        Knight = 4,
        Rook = 5,
        Pawn = 6

    }

   public class Piece
    {

        public Type Type { get; set; }
        public Color Color { get; set; }
        public uint MoveCount { get; set; }
        public Piece(Type type, Color color)
        {
            this.Type = type;
            this.Color = color;

        }
        /// <summary>
        /// Solves the reference type issue. 
        /// </summary>
        /// <param name="piece"></param>
        public Piece(Piece piece)
        {


            Type = piece.Type;
            MoveCount = piece.MoveCount;
        }


    }


}






