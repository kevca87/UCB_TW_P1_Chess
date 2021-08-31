using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Player
    {
        public Color ColorSide { get; set; }
        public List<Piece> PlayerActivePieces { get; set; }
        public List<Piece> PlayerInactivePieces { get; set; }
        public Player(Color colorSide)
        {
            PlayerActivePieces = new List<Piece>();
            PlayerInactivePieces = new List<Piece>();
            ColorSide = colorSide;
        }
        public void startPos(Board boardGame)
        {
            int pawn_number = 1;
            //https://stackoverflow.com/questions/105372/how-to-enumerate-an-enum
            foreach (ColumnEnum column in (ColumnEnum[])Enum.GetValues(typeof(ColumnEnum)))
            {
                Square sqInit;
                if (ColorSide == Color.White)
                {
                    sqInit = boardGame.getSquare(column, RowEnum.r2);
                }
                else
                {
                    sqInit = boardGame.getSquare(column, RowEnum.r7);
                }
                Pawn p = new Pawn(ColorSide, sqInit, pawn_number);
                pawn_number++;
                p.OccupySquare(sqInit); //sqInit = p.OccupySquare(sqInit);
                //boardGame.SetSquare(sqInit);
                PlayerActivePieces.Add(p);
            }
        }
        public Piece requestMove(string pieceAbb, Square squareDest)
        {
            //Use of Linq and Lambdas
            Piece pieceToMove = PlayerActivePieces.FirstOrDefault(piece => piece.Abb == pieceAbb);
            if (pieceToMove == null)
            {
                Exception e = new Exception("Esa pieza no existe o no esta en su poder");
                throw e;
            }
            try
            {
                squareDest = pieceToMove.Move(squareDest);
            }
            catch (Exception e)
            {
                throw e;
            }
            return pieceToMove;
        }
    }
}
