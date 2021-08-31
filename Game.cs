using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        Board BoardGame { get; set; } = new Board();
        public List<string> MovementsHistorial { get; set; } = new List<string>();
        public void play()
        {

            Player1 = new Player(Color.White);
            Player2 = new Player(Color.Black);
            Player1.startPos(BoardGame);
            Player2.startPos(BoardGame);
            string p1Request, p1SqDestName, p1PieceAbb;
            string p2Request, p2SqDestName, p2PieceAbb;

            BoardGame.GetInfo();

            while (true)
            {
                p1Request = Console.ReadLine();
                p1PieceAbb = p1Request.Split(' ')[0];
                p1SqDestName = p1Request.Split(' ')[1];
                //TODO Usar un try catch
                Square p1SqDest = BoardGame.getSquare(p1SqDestName);
                try
                {
                    Piece moveP1 = Player1.requestMove(p1PieceAbb, p1SqDest);
                    Console.WriteLine($"{moveP1.FullName} -> {moveP1.ActualPos}");
                    BoardGame.GetInfo();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                //BoardGame.movePiece();

                p2Request = Console.ReadLine();
                p2PieceAbb = p2Request.Split(' ')[0];
                p2SqDestName = p2Request.Split(' ')[1];
                //TODO Usar un try catch
                Square p2SqDest = BoardGame.getSquare(p2SqDestName);
                try
                {
                    Piece moveP2 = Player2.requestMove(p2PieceAbb, p2SqDest);
                    Console.WriteLine($"{moveP2.FullName} -> {moveP2.ActualPos}");
                    BoardGame.GetInfo();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                /*p2Request = Console.ReadLine();
                p2PieceAbb = p2Request.Split(' ')[0];
                p2SqDestName = p2Request.Split(' ')[1];
                var moveP2 = Player2.requestMove(p2PieceAbb, p2SqDestName);
                Console.WriteLine(moveP2);*/
                //BoardGame.movePiece();
            }
        }
    }
}
