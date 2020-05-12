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
            //dá print ao board
            ui.Print(board);
        }

    }

}