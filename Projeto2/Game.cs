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
            //do
            //dá print ao board
            ui.Print(board);

            //possivel modo de fazer mover a peça. Já que temos todas as posiçôes
            //no switch verificar se há alguma peça no sitio pedido 
            //depois moverS
            //while(!End)
        }

    }

}