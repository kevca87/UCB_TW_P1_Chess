using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Player
    {
        public List<Piece> PlayerActivePieces { get; set; }
        public List<Piece> PlayerInactivePieces { get; set; }
        public Player()
        {
            PlayerActivePieces = new List<Piece>();
            startPos();
            PlayerInactivePieces = new List<Piece>();
        }
        public void startPos()
        {
            //https://stackoverflow.com/questions/105372/how-to-enumerate-an-enum
            foreach (ColumnEnum column in (ColumnEnum[])Enum.GetValues(typeof(ColumnEnum)))
            {
                PlayerActivePieces.Add(new Pawn(Color.White, (int)column));
                PlayerActivePieces.Add(new Pawn(Color.Black, (int)column));
            }
        }
        public string requestMove(string pieceAbb, string squareDestAbb)
        {
            //Use of Linq and Lambdas
            //Piece pieceToMove = PlayerActivePieces.FirstOrDefault(piece => piece.Abb == pieceAbb);
            //pieceToMove.isValidMovement(squareDestination);
            return $"{pieceAbb} moved to {squareDestAbb}";
        }
    }
}
