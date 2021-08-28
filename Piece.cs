using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public abstract class Piece
    {

        public Color ColorSide { get; set; }
        public int RowInit { get; set; }
        public int ColumnInit { get; set; }
        public string Name { get; set; }
        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Abb { get; set; }

        public Piece(Color colorSide, int rowInit, int columnInit, string name, string abb)
        {
            ColorSide = colorSide;
            RowInit = rowInit;
            ColumnInit = columnInit;
            Name = name;
            if (colorSide == Color.Black)
            {
                FullName = $"Black {name}";
                Abb = $"b{abb}";
            }
            else
            {
                FullName = $"White {name}";
                Abb = $"b{abb}";
            }
        }

    }
}
