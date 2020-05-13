using System;
namespace Projeto2
{
    public class Board
    {
        //cria um array de arrays
        Pieces [][] board = new Pieces[5][];
        //completa o tabuleiro com as peças
        private Pieces B1,B2,B3,B4,B5,B6,W1,W2,W3,W4,W5,W6;
        public Board()
        {
            B1 = new Pieces("B1", Color.Black,1);
            B2 = new Pieces("B2", Color.Black,2);
            B3 = new Pieces("B3", Color.Black,3);
            B4 = new Pieces("B4", Color.Black,4);
            B5 = new Pieces("B5", Color.Black,5);
            B6 = new Pieces("B6", Color.Black,6);
            W1 = new Pieces("W1", Color.Black,8);
            W2 = new Pieces("W2", Color.Black,9);
            W3 = new Pieces("W3", Color.Black,10);
            W4 = new Pieces("W4", Color.Black,11);
            W5 = new Pieces("W5", Color.Black,12);
            W6 = new Pieces("W6", Color.Black,13);

            board[0] = new Pieces[3] {B1,B2,B3};
            board[1] = new Pieces[3] {B4,B5,B6}; 
            board[2] = new Pieces[1] {new Pieces()};
            board[3] = new Pieces[3] {W4,W5,W6};
            board[4] = new Pieces[3] {W1,W2,W3};  
        }

        /*public bool End
        {
            get
            {

            }
        }*/
        //recebe as coordenadas e vai pedir nome à posições
        public string GetPieceName( int y, int x )
        {
            return board[y][x].name;
            
        }
        

        

    }
}