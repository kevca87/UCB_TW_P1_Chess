using System;
using System.Collections.Generic;
using System.Text;


namespace Chess
{
    public class Pawn : Piece
    {
        public Pawn(Color colorSide, int columnInit) : base(colorSide,(int)RowEnum.r2,columnInit,"Pawn","p"){
            if (colorSide == Color.Black)
            {
                RowInit = (int)RowEnum.r7;
            }
        }
    }
}
