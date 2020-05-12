using System;
namespace Projeto2
{
    public class Board
    {
        //cria um array de arrays
        Pieces [][] board = new Pieces[5][];
        //completa o tabuleiro com as peças
        public Board()
        {

            board[0] = new Pieces[3] {new Pieces("B1", Color.Black,1),new Pieces("B2", Color.Black,2),new Pieces("B3", Color.Black,3)};
            board[1] = new Pieces[3] {new Pieces("B4", Color.Black,4),new Pieces("B5", Color.Black,5),new Pieces("B6", Color.Black,6)}; 
            board[2] = new Pieces[1] {new Pieces()};
            board[3] = new Pieces[3] {new Pieces("W4", Color.White,8),new Pieces("W5", Color.White,9),new Pieces("W6", Color.White,10)};
            board[4] = new Pieces[3] {new Pieces("W1", Color.White,11),new Pieces("W2", Color.White,12),new Pieces("W3", Color.White,13)};  
        }
        //recebe as coordenadas e vai pedir nome à posições
        public string GetPieceName( int y, int x )
        {
            return board[y][x].GetName();
        }

        

    }
}