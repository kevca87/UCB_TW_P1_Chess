using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Board BoardGame { get; set; }
        public List<string> MovementsHistorial { get; set; } = new List<string>();
        public void play()
        {
            Player1 = new Player();
            Player2 = new Player();
            string p1Request;
            string p2Request;
            string p1SqDestName;
            string p2SqDestName;
            string p1PieceAbb;
            string p2PieceAbb;
            while(true)
            {
                p1Request = Console.ReadLine();
                p1PieceAbb = p1Request.Split(' ')[0];
                p1SqDestName = p1Request.Split(' ')[1];
                var moveP1 = Player1.requestMove(p1PieceAbb, p1SqDestName);
                Console.WriteLine(moveP1);
                //BoardGame.movePiece();

                p2Request = Console.ReadLine();
                p2PieceAbb = p2Request.Split(' ')[0];
                p2SqDestName = p2Request.Split(' ')[1];
                var moveP2 = Player2.requestMove(p2PieceAbb, p2SqDestName);
                Console.WriteLine(moveP2);
                //BoardGame.movePiece();
            }
        }
    }
}
