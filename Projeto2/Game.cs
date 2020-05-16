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
            ui.PrintRules();
            do
            {
                Pieces piece;
                Position nextMovePos;
                int move;
                int numPiece = 0;
                //dá print ao board
                ui.PrintBoard(board);
                numPiece = ui.AskForChosenPiece(board.Turn);

                piece = board.GiveChosenPiece(numPiece);
                
                move = ui.ReadMovement();
                nextMovePos = ConvertToPos(move);

                if(!board.CanMove(piece, nextMovePos))
                {
                    ui.RenderMessage("This is not a legal move");
                }
                
                

            }while(board.End);
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
                case 7: return new Position (2,0);
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