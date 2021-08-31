using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Horse : Piece
    {
        public Horse(Color colorSide,Square initPos) : base(colorSide, initPos, "Horse", "h") { }

        public override bool IsValidMovement(Square squareDestination)
        {
            throw new NotImplementedException();
        }

        public override Square Move(Square squareDestination)
        {
            return squareDestination;
        }
    }
}
