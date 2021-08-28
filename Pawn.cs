using System;
using System.Collections.Generic;
using System.Text;


namespace Chess
{
    public class Pawn : Piece
    {
        public Pawn(Color colorSide, int rowInit, int columnInit) : base(colorSide,rowInit,columnInit,"Pawn","p"){ }
    }
}
