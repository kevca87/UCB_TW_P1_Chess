using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public enum ColumnEnum
    {
        cA,
        cB,
        cC,
        cD,
        cE,
        cF,
        cG,
        cH
    }
    public enum RowEnum
    {
        r1,
        r2,
        r3,
        r4,
        r5,
        r6,
        r7,
        r8
    }
    class Board
    {
        public Square[,] Matrix { get; set; } = new Square[8,8];
        public Board()
        {
            for (int r= (int)RowEnum.r1; r<8;r++)
            {
                for (int c = (int)ColumnEnum.cA; c < 8; c++)
                {
                    Matrix[r,c] = new Square(r,c);
                }
            }
        }
        public Square getSquare(ColumnEnum col,RowEnum row)
        {
            return Matrix[(int)row,(int)col];
        }
        public Square getSquare(string squareName)
        {
            const int ascci_a_code = 97;
            char columnChar = squareName[0];
            char rowChar = squareName[1];
            int col = columnChar - ascci_a_code;
            int row = (int)Char.GetNumericValue(rowChar) - 1;
            return Matrix[row,col];
        }
        public void SetSquare(Square sqNew)
        {
            int c = sqNew.Column;
            int r = sqNew.Row;
            Matrix[r, c] = sqNew;
            // check if void works
        }
        public void GetInfo()
        {
            for (int r=7; r>=0;r--)
            {
                for (int c = 0; c < 8; c++)
                {
                    Matrix[r, c].GetInfo();
                }
                Console.WriteLine();
            }
        }

    }
}
