using System;
namespace Projeto2
{
    public class Game
    {
        private Board board;
        //private int i;
        private UserInterface ui;
        //instacia o board e ui
        public Game()
        {
            board = new Board();
            ui = new UserInterface();
        }
        public void Play()
        {
            do
            {
                Pieces peça;
                Position nextMovePos;
                int move;
                //dá print ao board
                ui.PrintBoard(board);
                peça = ui.ReadChosenPiece(board);
                //nextMovePos = ConvertToPos(move);
                
                move = ui.ReadMovement();
                Console.WriteLine(move);
                nextMovePos = ConvertToPos(move);
                board.MakeMove(peça,nextMovePos);
                ui.PrintBoard(board);

            }while(!board.End);
        }

        public Position ConvertToPos(int num)
        {
            switch (num)
            {
                case 1: return new Position (0,0);
                case 2: return new Position (0,1);
                case 3: return new Position (0,2);
                case 4: return new Position (1,0);
                case 5: return new Position (1,1);
                case 6: return new Position (1,2);
                case 8: return new Position (3,0);
                case 9: return new Position (3,1);
                case 10: return new Position (3,2);
                case 11: return new Position (4,0);
                case 12: return new Position (4,1);
                case 13: return new Position (4,2);
                default: return null;
            }
        }

    }

}