using chess.core;

namespace chess.business
{
    public class MovementChecker
    {

        public static bool[,] CheckWhitePawnMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] newMovement = new bool[8, 8];
            if ((x >= 0 && x < 8) && (y >= 0 && y < 8))
            {
                if (y == 1)
                {
                    if (pieces[x, 2] == null && pieces[x, 3] == null)
                    {
                        newMovement[x, 2] = true;
                        newMovement[x, 3] = true;
                    }
                    if (pieces[x, 2] == null)
                    {
                        newMovement[x, 2] = true;

                    }

                }
                if (y > 1 && y < 7)
                {
                    if (pieces[x, y + 1] == null)
                    {
                        newMovement[x, y + 1] = true;

                    }

                }
                /// <summary>
                /// Checking all Attack moves for the white Pawn 
                /// </summary>
                /// <param name="8"></param>
                /// <returns> New Attac</returns>
                /// 

                if ((x > 0 && x < 7) && (y > 0 && y < 7))
                {
                    // Handeling NullReferenceException When trying to enter a class property
                    // Solution: Checking if Not NULL before entering the class Property/field or Method 
                    // Or use the ? Operator AFTER entering the class property/field or Method see the example 

                    if (pieces[x + 1, y + 1] != null)
                    {
                        if (pieces[x + 1, y + 1].Color == Color.Black)
                        {

                            newMovement[x + 1, y + 1] = true;

                        }
                    }

                    // evaluation false ???? It did not work when i used else if
                    if ((pieces[x - 1, y + 1] != null))
                    {
                        if ((pieces[x - 1, y + 1].Color == Color.Black))
                        {
                            newMovement[x - 1, y - 1] = true;
                        }

                    }



                }

            }

            return newMovement;
        }


        public static bool[][] CheckBlackPawnMoves(int x, int y, Piece[][] pieces)
        {
            bool[][] newMovement = new bool[8][];
            // pieces.BoardPiece[0,1]
            if ((x >= 0 && x < 8) && (y >= 0 && y < 8))
            {
                if (y == 6)
                {
                    if (pieces[x][5] == null && pieces[x][4] == null)
                    {
                        newMovement[x][5] = true;
                        newMovement[x][4] = true;

                    }
                    else if (pieces[x][5] == null)
                    {
                        newMovement[x][5] = true;

                    }

                }
                else if (y > 0 && y < 6)
                {
                    if (pieces[x][y - 1] == null)
                    {
                        newMovement[x][y - 1] = true;

                    }

                }
                if (x > 0 && y > 0)
                {
                    if (pieces[x - 1][y - 1] != null && pieces[x - 1][y - 1]?.Color == Color.White)
                    {
                        newMovement[x - 1][y - 1] = true;

                    }
                    if (pieces[x + 1][y - 1]?.Color == Color.White)
                    {
                        newMovement[x - 1][y - 1] = true;
                    }

                }

            }

            return newMovement;
        }


        public static bool[,] CheckWhiteKingMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] whiteKIngMovement = new bool[8, 8];
            if (pieces[x, y + 1] == null || pieces[x, y + 1].Color == Color.Black)
            {
                whiteKIngMovement[x, y + 1] = true;
            }

            if (pieces[x, y - 1] == null || pieces[x, y - 1].Color == Color.Black)
            {
                whiteKIngMovement[x, y - 1] = true;
            }
            if (pieces[x + 1, y] == null || pieces[x + 1, y].Color == Color.Black)
            {
                whiteKIngMovement[x + 1, y] = true;
            }
            if (pieces[x - 1, y] == null || pieces[x - 1, y].Color == Color.Black)
            {
                whiteKIngMovement[x - 1, y] = true;
            }
            if (pieces[x + 1, y + 1] == null || pieces[x + 1, y + 1].Color == Color.Black)
            {
                whiteKIngMovement[x + 1, y + 1] = true;
            }
            if (pieces[x - 1, y + 1] == null || pieces[x - 1, y + 1].Color == Color.Black)
            {
                whiteKIngMovement[x - 1, y + 1] = true;
            }
            if (pieces[x + 1, y - 1] == null || pieces[x + 1, y - 1].Color == Color.Black)
            {
                whiteKIngMovement[x + 1, y - 1] = true;
            }
            if (pieces[x - 1, y - 1] == null || pieces[x - 1, y - 1].Color == Color.Black)
            {
                whiteKIngMovement[x + 1, y - 1] = true;
            }

            return whiteKIngMovement;

        }

        public static bool[,] CheckBlackKingMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] whiteKIngMovement = new bool[8, 8];
            if (y == 7)
            {
                if (pieces[x, y - 1] == null || pieces[x, y - 1].Color == Color.White)
                {
                    whiteKIngMovement[x, y - 1] = true;
                }
                if (pieces[x + 1, y] == null || pieces[x + 1, y].Color == Color.White)
                {
                    whiteKIngMovement[x + 1, y] = true;
                }
                if (pieces[x - 1, y] == null || pieces[x - 1, y].Color == Color.White)
                {
                    whiteKIngMovement[x - 1, y] = true;
                }
                if (pieces[x + 1, y - 1] == null || pieces[x + 1, y - 1].Color == Color.White)
                {
                    whiteKIngMovement[x + 1, y - 1] = true;
                }
                if (pieces[x - 1, y - 1] == null || pieces[x - 1, y - 1].Color == Color.White)
                {
                    whiteKIngMovement[x + 1, y - 1] = true;
                }

            }
            if (y > 0 && y < 7)
            {
                if (pieces[x, y - 1] == null || pieces[x, y - 1].Color == Color.White)
                {
                    whiteKIngMovement[x, y - 1] = true;
                }
                if (pieces[x + 1, y] == null || pieces[x + 1, y].Color == Color.White)
                {
                    whiteKIngMovement[x + 1, y] = true;
                }
                if (pieces[x - 1, y] == null || pieces[x - 1, y].Color == Color.White)
                {
                    whiteKIngMovement[x - 1, y] = true;
                }
                if (pieces[x + 1, y - 1] == null || pieces[x + 1, y - 1].Color == Color.White)
                {
                    whiteKIngMovement[x + 1, y - 1] = true;
                }
                if (pieces[x - 1, y - 1] == null || pieces[x - 1, y - 1].Color == Color.White)
                {
                    whiteKIngMovement[x + 1, y - 1] = true;
                }
                if (pieces[x, y + 1] == null || pieces[x, y + 1].Color == Color.White)
                {
                    whiteKIngMovement[x, y + 1] = true;
                }

                if (pieces[x + 1, y + 1] == null || pieces[x + 1, y + 1].Color == Color.White)
                {
                    whiteKIngMovement[x + 1, y + 1] = true;
                }
                if (pieces[x - 1, y + 1] == null || pieces[x - 1, y + 1].Color == Color.White)
                {
                    whiteKIngMovement[x - 1, y + 1] = true;
                }

            }

            return whiteKIngMovement;

        }


        public static bool[,] CheckWhiteRookMoves(int x, int y, Piece[,] pieces)

        {
            bool[,] whiteRookMoves = new bool[8, 8];

            if (x == 0 && y == 0)
            {
                for (int i = 0; i < 6; i++)
                {

                    if (pieces[x, i + 1] == null || pieces[x, i + 1].Color == Color.Black)
                    {
                        whiteRookMoves[x, i + 1] = true;
                    }

                }
                for (int i = 0; i < 7; i++)
                {

                    if (pieces[i + 1, y] == null || pieces[i + 1, y].Color == Color.Black)
                    {
                        whiteRookMoves[i + 1, y] = true;
                    }

                }

            }
            else if (x == 0 && y == 7)
            {
                for (int i = 0; i < 6; i++)
                {

                    if (pieces[x, i + 1] == null || pieces[x, i + 1].Color == Color.Black)
                    {
                        whiteRookMoves[x, i + 1] = true;
                    }

                }
                for (int i = 7; i > 0; i--)
                {
                    if (pieces[i - 1, y] == null || pieces[i - 1, y].Color == Color.Black)
                    {
                        whiteRookMoves[i - 1, y] = true;

                    }

                }

            }
            else
            {
                for (int i = 0; i < 6; i++)
                {

                    if (pieces[x, i + 1] == null || pieces[x, i + 1].Color == Color.Black)
                    {
                        whiteRookMoves[x, i + 1] = true;
                    }

                }
                for (int i = 0; i < 7; i++)
                {

                    if (pieces[i + 1, y] == null || pieces[i + 1, y].Color == Color.Black)
                    {
                        whiteRookMoves[i + 1, y] = true;
                    }

                }

                for (int i = 7; i > 0; i--)
                {
                    if (pieces[x, i - 1] == null || pieces[x, i - 1].Color == Color.Black)
                    {
                        whiteRookMoves[x, i - 1] = true;

                    }

                }
                for (int i = 7; i > 0; i--)
                {
                    if (pieces[i - 1, y] == null || pieces[i - 1, y].Color == Color.Black)
                    {
                        whiteRookMoves[i - 1, y] = true;

                    }

                }
            }

            return whiteRookMoves;

        }

        public static bool[,] CheckBlackRookMoves(int x, int y, Piece[,] pieces)

        {
            bool[,] whiteRookMoves = new bool[8, 8];

            if (x == 0 && y == 7)
            {
                for (int i = 0; i < 6; i++)
                {

                    if (pieces[x, i + 1] == null || pieces[x, i + 1].Color == Color.Black)
                    {
                        whiteRookMoves[x, i + 1] = true;
                    }

                }
                for (int i = 7; i > 0; i--)
                {
                    if (pieces[i - 1, y] == null || pieces[i - 1, y].Color == Color.Black)
                    {
                        whiteRookMoves[i - 1, y] = true;

                    }

                }

            }
            else if (x == 7 && y == 7)
            {
                for (int i = 7; i > 0; i--)
                {
                    if (pieces[x, i - 1] == null || pieces[x, i - 1].Color == Color.Black)
                    {
                        whiteRookMoves[x, i - 1] = true;

                    }

                }
                for (int i = 0; i < 7; i++)
                {

                    if (pieces[i + 1, y] == null || pieces[i + 1, y].Color == Color.Black)
                    {
                        whiteRookMoves[i + 1, y] = true;

                    }

                }

            }
            else
            {
                for (int i = 0; i < 6; i++)
                {

                    if (pieces[x, i + 1] == null || pieces[x, i + 1].Color == Color.Black)
                    {
                        whiteRookMoves[x, i + 1] = true;
                    }

                }
                for (int i = 0; i < 7; i++)
                {

                    if (pieces[i + 1, y] == null || pieces[i + 1, y].Color == Color.Black)
                    {
                        whiteRookMoves[i + 1, y] = true;
                    }

                }

                for (int i = 7; i > 0; i--)
                {
                    if (pieces[x, i - 1] == null || pieces[x, i - 1].Color == Color.Black)
                    {
                        whiteRookMoves[x, i - 1] = true;

                    }

                }
                for (int i = 7; i > 0; i--)
                {
                    if (pieces[i - 1, y] == null || pieces[i - 1, y].Color == Color.Black)
                    {
                        whiteRookMoves[i - 1, y] = true;

                    }

                }
            }

            return whiteRookMoves;

        }


        public static bool[,] CheckWhiteQueenMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] whiteQueenMoves = new bool[8, 8];
            for (int i = x + 1; i < 8; i++)
            {
                if (pieces[i, y] != null && pieces[i, y].Color == Color.Black)
                {
                    whiteQueenMoves[i, y] = true;
                    break;

                }
                if (pieces[i, y] != null && pieces[i, y].Color == Color.White)
                {

                    break;

                }
                if (pieces[i, y] == null)
                {
                    whiteQueenMoves[i, y] = true;
                }

            }
            for (int i = x - 1; i >= 0; i--)
            {
                if (pieces[i, y] != null && pieces[i, y].Color == Color.Black)
                {
                    whiteQueenMoves[i, y] = true;
                    break;

                }
                if (pieces[i, y] != null && pieces[i, y].Color == Color.White)
                {

                    break;

                }
                if (pieces[i, y] == null)
                {
                    whiteQueenMoves[i, y] = true;
                }

            }
            for (int i = y - 1; i >= 0; i--)
            {
                if (pieces[x, i] != null && pieces[x, i].Color == Color.Black)
                {
                    whiteQueenMoves[x, i] = true;
                    break;

                }
                if (pieces[x, i] != null && pieces[x, i].Color == Color.White)
                {

                    break;

                }
                if (pieces[x, i] == null)
                {
                    whiteQueenMoves[x, i] = true;
                }

            }
            for (int i = y + 1; i < 8; i++)
            {
                if (pieces[x, i] != null && pieces[x, i].Color == Color.Black)
                {
                    whiteQueenMoves[x, i] = true;
                    break;

                }
                if (pieces[x, i] != null && pieces[x, i].Color == Color.White)
                {

                    break;

                }
                if (pieces[x, i] == null)
                {
                    whiteQueenMoves[x, i] = true;
                }

            }
            for (int v = x, h = y;
                (v < 7) && (h < 7); v++, h++)
            {
                if (pieces[v + 1, h + 1] != null && pieces[v + 1, h + 1].Color == Color.Black)
                {
                    whiteQueenMoves[v + 1, h + 1] = true;
                    break;

                }
                if (pieces[v + 1, h + 1] != null && pieces[v + 1, h + 1].Color == Color.White)
                {

                    break;

                }
                if (pieces[v + 1, h + 1] == null)
                {
                    whiteQueenMoves[v + 1, h + 1] = true;
                }

            }
            for (int v = x, h = y;
                (v > 0) && (h > 0); v--, h--)
            {
                if (pieces[v - 1, h - 1] != null && pieces[v - 1, h - 1].Color == Color.Black)
                {
                    whiteQueenMoves[v - 1, h - 1] = true;
                    break;

                }
                if (pieces[v - 1, h - 1] != null && pieces[v - 1, h - 1].Color == Color.White)
                {

                    break;

                }
                if (pieces[v - 1, h - 1] == null)
                {
                    whiteQueenMoves[v - 1, h - 1] = true;
                }

            }

            for (int v = x, h = y;
                (v < 7) && (h > 0); v++, h--)
            {
                if (pieces[v + 1, h - 1] != null && pieces[v + 1, h - 1].Color == Color.Black)
                {
                    whiteQueenMoves[v + 1, h - 1] = true;
                    break;

                }
                if (pieces[v + 1, h - 1] != null && pieces[v + 1, h - 1].Color == Color.White)
                {

                    break;

                }
                if (pieces[v + 1, h - 1] == null)
                {
                    whiteQueenMoves[v + 1, h - 1] = true;
                }

            }
            for (int v = x, h = y;
                (v > 0) && (h < 7); v--, h--)
            {
                if (pieces[v - 1, h + 1] != null && pieces[v - 1, h + 1].Color == Color.Black)
                {
                    whiteQueenMoves[v - 1, h - 1] = true;
                    break;

                }
                if (pieces[v - 1, h + 1] != null && pieces[v - 1, h + 1].Color == Color.White)
                {

                    break;

                }
                if (pieces[v - 1, h + 1] == null)
                {
                    whiteQueenMoves[v - 1, h + 1] = true;
                }

            }

            return whiteQueenMoves;

        }


        public static bool[,] CheckBlackQueenMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] whiteQueenMoves = new bool[8, 8];
            for (int i = x + 1; i < 8; i++)
            {
                if (pieces[i, y] != null && pieces[i, y].Color == Color.White)
                {
                    whiteQueenMoves[i, y] = true;
                    break;

                }
                if (pieces[i, y] != null && pieces[i, y].Color == Color.Black)
                {

                    break;

                }
                if (pieces[i, y] == null)
                {
                    whiteQueenMoves[i, y] = true;
                }

            }
            for (int i = x - 1; i >= 0; i--)
            {
                if (pieces[i, y] != null && pieces[i, y].Color == Color.White)
                {
                    whiteQueenMoves[i, y] = true;
                    break;

                }
                if (pieces[i, y] != null && pieces[i, y].Color == Color.Black)
                {

                    break;

                }
                if (pieces[i, y] == null)
                {
                    whiteQueenMoves[i, y] = true;
                }

            }
            for (int i = y - 1; i >= 0; i--)
            {
                if (pieces[x, i] != null && pieces[x, i].Color == Color.White)
                {
                    whiteQueenMoves[x, i] = true;
                    break;

                }
                if (pieces[x, i] != null && pieces[x, i].Color == Color.Black)
                {

                    break;

                }
                if (pieces[x, i] == null)
                {
                    whiteQueenMoves[x, i] = true;
                }

            }
            for (int i = y + 1; i < 8; i++)
            {
                if (pieces[x, i] != null && pieces[x, i].Color == Color.White)
                {
                    whiteQueenMoves[x, i] = true;
                    break;

                }
                if (pieces[x, i] != null && pieces[x, i].Color == Color.Black)
                {

                    break;

                }
                if (pieces[x, i] == null)
                {
                    whiteQueenMoves[x, i] = true;
                }

            }
            for (int v = x, h = y;
                (v < 7) && (h < 7); v++, h++)
            {
                if (pieces[v + 1, h + 1] != null && pieces[v + 1, h + 1].Color == Color.White)
                {
                    whiteQueenMoves[v + 1, h + 1] = true;
                    break;

                }
                if (pieces[v + 1, h + 1] != null && pieces[v + 1, h + 1].Color == Color.Black)
                {

                    break;

                }
                if (pieces[v + 1, h + 1] == null)
                {
                    whiteQueenMoves[v + 1, h + 1] = true;
                }

            }
            for (int v = x, h = y;
                (v > 0) && (h > 0); v--, h--)
            {
                if (pieces[v - 1, h - 1] != null && pieces[v - 1, h - 1].Color == Color.White)
                {
                    whiteQueenMoves[v - 1, h - 1] = true;
                    break;

                }
                if (pieces[v - 1, h - 1] != null && pieces[v - 1, h - 1].Color == Color.Black)
                {

                    break;

                }
                if (pieces[v - 1, h - 1] == null)
                {
                    whiteQueenMoves[v - 1, h - 1] = true;
                }

            }

            for (int v = x, h = y;
                (v < 7) && (h > 0); v++, h--)
            {
                if (pieces[v + 1, h - 1] != null && pieces[v + 1, h - 1].Color == Color.White)
                {
                    whiteQueenMoves[v + 1, h - 1] = true;
                    break;

                }
                if (pieces[v + 1, h - 1] != null && pieces[v + 1, h - 1].Color == Color.Black)
                {

                    break;

                }
                if (pieces[v + 1, h - 1] == null)
                {
                    whiteQueenMoves[v + 1, h - 1] = true;
                }

            }
            for (int v = x, h = y;
                (v > 0) && (h < 7); v--, h--)
            {
                if (pieces[v - 1, h + 1] != null && pieces[v - 1, h + 1].Color == Color.White)
                {
                    whiteQueenMoves[v - 1, h - 1] = true;
                    break;

                }
                if (pieces[v - 1, h + 1] != null && pieces[v - 1, h + 1].Color == Color.Black)
                {

                    break;

                }
                if (pieces[v - 1, h + 1] == null)
                {
                    whiteQueenMoves[v - 1, h + 1] = true;
                }

            }

            return whiteQueenMoves;

        }


        public static bool[,] CheckWhiteBishopMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] newMovements = new bool[8, 8];
            for (int v = x, h = y;
                (v < 7) && (h < 7); v++, h++)
            {
                if (pieces[v + 1, h + 1] != null && pieces[v + 1, h + 1].Color == Color.Black)
                {
                    newMovements[v + 1, h + 1] = true;
                    break;

                }
                if (pieces[v + 1, h + 1] != null && pieces[v + 1, h + 1].Color == Color.White)
                {

                    break;

                }
                if (pieces[v + 1, h + 1] == null)
                {
                    newMovements[v + 1, h + 1] = true;
                }

            }
            for (int v = x, h = y;
                (v > 0) && (h > 0); v--, h--)
            {
                if (pieces[v - 1, h - 1] != null && pieces[v - 1, h - 1].Color == Color.Black)
                {
                    newMovements[v - 1, h - 1] = true;
                    break;

                }
                if (pieces[v - 1, h - 1] != null && pieces[v - 1, h - 1].Color == Color.White)
                {

                    break;

                }
                if (pieces[v - 1, h - 1] == null)
                {
                    newMovements[v - 1, h - 1] = true;
                }

            }

            for (int v = x, h = y;
                (v > 0) && (h < 7); v--, h--)
            {
                if (pieces[v - 1, h + 1] != null && pieces[v - 1, h + 1].Color == Color.Black)
                {
                    newMovements[v - 1, h - 1] = true;
                    break;

                }
                if (pieces[v - 1, h + 1] != null && pieces[v - 1, h + 1].Color == Color.White)
                {

                    break;

                }
                if (pieces[v - 1, h + 1] == null)
                {
                    newMovements[v - 1, h + 1] = true;
                }

            }
            for (int v = x, h = y;
                (v < 7) && (h > 0); v++, h--)
            {
                if (pieces[v + 1, h - 1] != null && pieces[v + 1, h - 1].Color == Color.Black)
                {
                    newMovements[v + 1, h - 1] = true;
                    break;

                }
                if (pieces[v + 1, h - 1] != null && pieces[v + 1, h - 1].Color == Color.White)
                {

                    break;

                }
                if (pieces[v + 1, h - 1] == null)
                {
                    newMovements[v + 1, h - 1] = true;
                }

            }

            return newMovements;
        }

        public static bool[,] CheckBlackBishopMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] newMovements = new bool[8, 8];
            for (int v = x, h = y;
                (v < 7) && (h < 7); v++, h++)
            {
                if (pieces[v + 1, h + 1] != null && pieces[v + 1, h + 1].Color == Color.White)
                {
                    newMovements[v + 1, h + 1] = true;
                    break;

                }
                if (pieces[v + 1, h + 1] != null && pieces[v + 1, h + 1].Color == Color.Black)
                {

                    break;

                }
                if (pieces[v + 1, h + 1] == null)
                {
                    newMovements[v + 1, h + 1] = true;
                }

            }
            for (int v = x, h = y;
                (v > 0) && (h > 0); v--, h--)
            {
                if (pieces[v - 1, h - 1] != null && pieces[v - 1, h - 1].Color == Color.White)
                {
                    newMovements[v - 1, h - 1] = true;
                    break;

                }
                if (pieces[v - 1, h - 1] != null && pieces[v - 1, h - 1].Color == Color.Black)
                {

                    break;

                }
                if (pieces[v - 1, h - 1] == null)
                {
                    newMovements[v - 1, h - 1] = true;
                }

            }

            for (int v = x, h = y;
                (v > 0) && (h < 7); v--, h--)
            {
                if (pieces[v - 1, h + 1] != null && pieces[v - 1, h + 1].Color == Color.White)
                {
                    newMovements[v - 1, h - 1] = true;
                    break;

                }
                if (pieces[v - 1, h + 1] != null && pieces[v - 1, h + 1].Color == Color.Black)
                {

                    break;

                }
                if (pieces[v - 1, h + 1] == null)
                {
                    newMovements[v - 1, h + 1] = true;
                }

            }
            for (int v = x, h = y;
                (v < 7) && (h > 0); v++, h--)
            {
                if (pieces[v + 1, h - 1] != null && pieces[v + 1, h - 1].Color == Color.White)
                {
                    newMovements[v + 1, h - 1] = true;
                    break;

                }
                if (pieces[v + 1, h - 1] != null && pieces[v + 1, h - 1].Color == Color.Black)
                {

                    break;

                }
                if (pieces[v + 1, h - 1] == null)
                {
                    newMovements[v + 1, h - 1] = true;
                }

            }

            return newMovements;
        }


        public static bool[,] CheckWhiteKnightMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] newMovements = new bool[8, 8];
            if (pieces[x + 2, y + 1] == null || ((pieces[x + 2, y + 1] != null) && (pieces[x + 2, y + 1].Color == Color.Black)))
            {
                newMovements[x + 2, y + 1] = true;
            }
            if (pieces[x - 2, y + 1] == null || ((pieces[x - 2, y + 1] != null) && (pieces[x - 2, y + 1].Color == Color.Black)))
            {
                newMovements[x - 2, y + 1] = true;
            }
            if (pieces[x - 2, y - 1] == null || ((pieces[x - 2, y - 1] != null) && (pieces[x - 2, y - 1].Color == Color.Black)))
            {
                newMovements[x - 2, y - 1] = true;
            }
            if (pieces[x + 2, y - 1] == null || ((pieces[x + 2, y - 1] != null) && (pieces[x + 2, y - 1].Color == Color.Black)))
            {
                newMovements[x + 2, y - 1] = true;
            }
            if (pieces[x + 1, y + 2] == null || ((pieces[x + 1, y + 2] != null) && (pieces[x + 1, y + 2].Color == Color.Black)))
            {
                newMovements[x + 1, y + 2] = true;
            }
            if (pieces[x - 1, y + 2] == null || ((pieces[x - 1, y + 2] != null) && (pieces[x - 1, y + 2].Color == Color.Black)))
            {
                newMovements[x - 1, y + 2] = true;
            }
            if (pieces[x + 1, y - 2] == null || ((pieces[x + 1, y - 2] != null) && (pieces[x + 1, y - 2].Color == Color.Black)))
            {
                newMovements[x + 1, y - 2] = true;
            }
            if (pieces[x - 2, y - 1] == null || ((pieces[x - 1, y - 2] != null) && (pieces[x - 1, y - 2].Color == Color.Black)))
            {
                newMovements[x - 1, y - 2] = true;
            }

            return newMovements;
        }

        public static bool[,] CheckBlackKnightMoves(int x, int y, Piece[,] pieces)
        {
            bool[,] newMovements = new bool[8, 8];
            if (pieces[x + 2, y + 1] == null || ((pieces[x + 2, y + 1] != null) && (pieces[x + 2, y + 1].Color == Color.White)))
            {
                newMovements[x + 2, y + 1] = true;
            }
            if (pieces[x - 2, y + 1] == null || ((pieces[x - 2, y + 1] != null) && (pieces[x - 2, y + 1].Color == Color.White)))
            {
                newMovements[x - 2, y + 1] = true;
            }
            if (pieces[x - 2, y - 1] == null || ((pieces[x - 2, y - 1] != null) && (pieces[x - 2, y - 1].Color == Color.White)))
            {
                newMovements[x - 2, y - 1] = true;
            }
            if (pieces[x + 2, y - 1] == null || ((pieces[x + 2, y - 1] != null) && (pieces[x + 2, y - 1].Color == Color.White)))
            {
                newMovements[x + 2, y - 1] = true;
            }
            if (pieces[x + 1, y + 2] == null || ((pieces[x + 1, y + 2] != null) && (pieces[x + 1, y + 2].Color == Color.White)))
            {
                newMovements[x + 1, y + 2] = true;
            }
            if (pieces[x - 1, y + 2] == null || ((pieces[x - 1, y + 2] != null) && (pieces[x - 1, y + 2].Color == Color.White)))
            {
                newMovements[x - 1, y + 2] = true;
            }
            if (pieces[x + 1, y - 2] == null || ((pieces[x + 1, y - 2] != null) && (pieces[x + 1, y - 2].Color == Color.White)))
            {
                newMovements[x + 1, y - 2] = true;
            }
            if (pieces[x - 1, y - 2] == null || ((pieces[x - 1, y - 2] != null) && (pieces[x - 1, y - 2].Color == Color.White)))
            {
                newMovements[x - 1, y - 2] = true;
            }

            return newMovements;
        }


    }

}
