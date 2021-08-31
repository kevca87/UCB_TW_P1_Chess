using System;
using System.Collections.Generic;
using System.Text;


namespace Chess
{
    public class Pawn : Piece
    {
        public bool MovedFirstTime { get; set; } = true;
        public Pawn(Color colorSide, Square initPos,int number) : base(colorSide,initPos,"Pawn","p")
        {
            Abb = Abb + number.ToString();
        }
        public override bool IsValidMovement(Square squareDest)
        {
            bool ans = false;
            List<Func<Square, bool>> moveRules = new List<Func<Square, bool>>();
            //Se podria utilizar la interaccion con el bajo nivel pero por ahora Add
            moveRules.Add(IsTwoAheadMove);
            moveRules.Add(IsOneAheadMove);
            foreach (Func<Square, bool> move in moveRules)
            {
                ans = ans || move(squareDest);
                if (ans == true)
                {
                    break;
                }
                // Si ninguno es verdadero entonces el ans permanecera como false
                // Si al menos uno es verdadero entonces cambiara a true
            }
            return ans;
        }
        public override Square Move(Square squareDestination)
        {
            if (IsTheActualPos(squareDestination))
            {
                Exception e = new Exception("La pieza se encuentra en la casilla a la que quiere moverla");
                throw e;
            }
            if (IsValidMovement(squareDestination))
            {
                OccupySquare(squareDestination);
                FreeSquare(ActualPos);
                ActualPos = squareDestination;
                MovedFirstTime = false;
            }
            return ActualPos;
        }
        Func<Square, bool> MoveRule;
        private bool IsTwoAheadMove(Square sqDest)
        {
            bool ans = false;
            if (ActualPos.IsInSameColumn(sqDest) && MovedFirstTime == true)
            {
                if (ColorSide == Color.White && ActualPos.Row + 2 == sqDest.Row )
                {
                    ans = true;
                }
                else if (ColorSide == Color.Black && ActualPos.Row - 2 == sqDest.Row)
                {
                    ans = true;
                }
            }
            return ans;
        }
        private bool IsOneAheadMove(Square sqDest)
        {
            bool ans = false;
            if (ActualPos.IsInSameColumn(sqDest))
            {
                if (ColorSide == Color.White && ActualPos.Row + 1 == sqDest.Row)
                {
                    ans = true;
                }
                else if (ColorSide == Color.Black && ActualPos.Row - 1 == sqDest.Row)
                {
                    ans = true;
                }
            }
            return ans;
        }
        
        /*private bool IsPathFree(Square sqDest)
        {
            bool ans = false;
            for (int r = ActualPos.Row; r<=sqDest.Row; r++)
            {
                
            }
            return ans;
        }*/
        //Implementar is not the same square
    }
}
