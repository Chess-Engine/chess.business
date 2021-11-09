
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
    /// Enum for the piece Sort
    /// </summary>
    public enum Sort : byte
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

        public Sort Sort { get; set; }
        public Color Color { get; set; }
        public uint MoveCount { get; set; }
        public Piece(Sort Sort, Color color)
        {
            this.Sort = Sort;
            this.Color = color;

        }
        /// <summary>
        /// Solves the reference Sort issue. 
        /// </summary>
        /// <param name="piece"></param>
        public Piece(Piece piece)
        {


            Sort = piece.Sort;
            MoveCount = piece.MoveCount;
        }


    }


}






