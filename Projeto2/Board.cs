using System;
namespace Projeto2
{
    public class Board
    {
        //cria um array de arrays
        private Pieces [][] board = new Pieces[5][];
        //completa o tabuleiro com as peças
        public Pieces B1,B2,B3,B4,B5,B6,W1,W2,W3,W4,W5,W6,Empty;

        public int turn = 0 ;
        public Board()
        {
            B1 = new Pieces("B1", Color.Black);
            B2 = new Pieces("B2", Color.Black);
            B3 = new Pieces("B3", Color.Black);
            B4 = new Pieces("B4", Color.Black);
            B5 = new Pieces("B5", Color.Black);
            B6 = new Pieces("B6", Color.Black);
            W1 = new Pieces("W1", Color.Black);
            W2 = new Pieces("W2", Color.Black);
            W3 = new Pieces("W3", Color.Black);
            W4 = new Pieces("W4", Color.Black);
            W5 = new Pieces("W5", Color.Black);
            W6 = new Pieces("W6", Color.Black);
            Empty = new Pieces();
            board[0] = new Pieces[3] {B1,B2,B3};
            board[1] = new Pieces[3] {B4,B5,B6}; 
            board[2] = new Pieces[1] {Empty};
            board[3] = new Pieces[3] {W4,W5,W6};
            board[4] = new Pieces[3] {W1,W2,W3};  
        }

        public bool End
        {
            get
            {
                return true;
            }
        }
        //recebe as coordenadas e vai pedir nome à posições
        public string GetPieceName( int y, int x )
        {
            return board[y][x].name;
            
        }

        public bool MakeMove(Pieces pieces, Position pos)
        {
            if(board[pos.Row][pos.Col] == Empty)
            {
                board[pos.Row][pos.Col] = pieces;
                turn ++;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        

        /*public Board MovePiece ( Board board)
        {
            B1= board[4][0];
        }*/
    

    }
}