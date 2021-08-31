using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public enum StateEnum
    {
        Free,
        Occupied
    }
    public class Square
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public StateEnum State { get; set; } = StateEnum.Occupied;
        public Color OccupyingColor { get; set; }
        public Square(int row,int column)
        {
            Row = row;
            Column = column;
        }
        public bool IsOccupied()
        { 
            return State == StateEnum.Occupied; 
        }
        public bool IsInSameColumn(Square sqB)
        {
            return Column == sqB.Column;
        }
        public bool IsConsecutive(Square sqB)
        {
            return ((Row + 1 >= sqB.Row) && (Row - 1 <= sqB.Row)) && ((Column + 1 >= sqB.Column) && (Column - 1 <= sqB.Column));
        }
        public bool IsDiagonal(Square sqB)
        {
            return Math.Abs(Row - sqB.Row) == Math.Abs(Column - sqB.Column);
        }

        public override string ToString()
        {
            return $"(c: {Column}, r: {Row}";
        }

        public override bool Equals(object obj)
        {
            return obj is Square square &&
                   Row == square.Row &&
                   Column == square.Column;
        }
    }
}
