using System;

namespace Chess
{
    public enum Color
    {
        White,
        Black
    }
    class Program
    {
        static void Main(string[] args)
        {
            Piece p = new Pawn(Color.Black, 0, 0);
            Console.WriteLine(p.Abb);
        }
    }
}