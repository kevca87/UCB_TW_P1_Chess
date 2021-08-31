using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public abstract class Piece
    {

        public Color ColorSide { get; set; }
        public Square ActualPos { get; set; }
        public Square InitPos { get; set; }
        public string Name { get; set; }
        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Abb { get; set; }

        public Piece(Color colorSide, Square initPos, string name, string abb)
        {
            ColorSide = colorSide;
            InitPos = initPos;
            ActualPos = initPos;
            Name = name;
            if (colorSide == Color.Black)
            {
                FullName = $"Black {name}";
                Abb = $"b{abb}";
            }
            else
            {
                FullName = $"White {name}";
                Abb = $"w{abb}";
            }
        }
        public Square OccupySquare(Square square)
        {
            square.State = StateEnum.Occupied;
            square.OccupyingColor = ColorSide;
            return square;
        }
        public Square FreeSquare(Square square)
        {
            square.State = StateEnum.Free;
            //square.OccupyingColor = null;
            return square;
        }

        public abstract Square Move(Square squareDestination);

        public abstract bool IsValidMovement(Square squareDestination);
        public virtual bool IsTheActualPos(Square sqDest)
        {
            return ActualPos.Equals(sqDest);
        }

    }
}
