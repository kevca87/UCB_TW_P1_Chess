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
            Game g = new Game();
            g.play();
        }
    }
}