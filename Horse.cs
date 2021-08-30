using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Horse : Piece
    {
        public Horse(Color colorSide, int rowInit, int columnInit) : base(colorSide, rowInit, columnInit, "Horse", "h") { }

    }
}
