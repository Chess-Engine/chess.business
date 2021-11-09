
using System;

namespace chess.business
{

    [Serializable]

    public class Board
    {
        public Piece[,] BoardPiece = new Piece[8,8];
        public Board()
        {

            MainBoard();
        }

        /// <summary>
        /// Chess board is loaded with pieces.
        /// </summary>

        public void MainBoard()
        {

            BoardPiece[0,0] = new Piece(Sort.Rook, Color.White); // Rook White Left.
            BoardPiece[7,0] = new Piece(Sort.Rook, Color.White); // Rook White Right. 
            BoardPiece[0,7] = new Piece(Sort.Rook, Color.Black); // Rook Black Left.
            BoardPiece[7,8] = new Piece(Sort.Rook, Color.Black); //  Rook Black Right.
            BoardPiece[1,0] = new Piece(Sort.Knight, Color.White); // Knight White Left
            BoardPiece[6,0] = new Piece(Sort.Knight, Color.White); // Knight White right 
            BoardPiece[1,7] = new Piece(Sort.Knight, Color.Black); // Knight Black Right 
            BoardPiece[6,7] = new Piece(Sort.Knight, Color.Black); // Knight Black Right 
            BoardPiece[2,0] = new Piece(Sort.Bishop, Color.White); // Bishop White Left
            BoardPiece[5,0] = new Piece(Sort.Bishop, Color.White); // Bishop White Right
            BoardPiece[2,7] = new Piece(Sort.Bishop, Color.Black); // Bishop Black Right
            BoardPiece[5,7] = new Piece(Sort.Bishop, Color.Black); // Bishop Black Left
            BoardPiece[3,0] = new Piece(Sort.Queen, Color.White); // Queen White
            BoardPiece[3,7] = new Piece(Sort.Queen, Color.Black); // Queen Black
            BoardPiece[4,0] = new Piece(Sort.King, Color.White); // King White 
            BoardPiece[4,7] = new Piece(Sort.King, Color.Black); // King Black
            for (int i = 0; i < 8; i++)
            {
                BoardPiece[i,1] = new Piece(Sort.Pawn, Color.White); // Pawn White

            }
            for (int i = 0; i < 8; i++)
            {
                BoardPiece[i,6] = new Piece(Sort.Pawn, Color.Black); // Pawn Black

            }
            return;
        }

    }

}






