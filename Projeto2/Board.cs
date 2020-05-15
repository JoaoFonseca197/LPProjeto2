using System;
namespace Projeto2
{
    public class Board
    {
        //cria um array de arrays
        private Pieces [][] boardPieces = new Pieces[5][];
        //completa o tabuleiro com as peças
        public Pieces B1,B2,B3,B4,B5,B6,W1,W2,W3,W4,W5,W6,Empty;

        public int turn = 0 ;
        public Board()
        {
            B1 = new Pieces("B1", Color.Black, new Position(0,0));
            B2 = new Pieces("B2", Color.Black, new Position(0,1));
            B3 = new Pieces("B3", Color.Black, new Position(0,2));
            B4 = new Pieces("B4", Color.Black, new Position(1,0));
            B5 = new Pieces("B5", Color.Black, new Position(1,1));
            B6 = new Pieces("B6", Color.Black, new Position(1,0));
            W1 = new Pieces("W1", Color.Black, new Position(3,0));
            W2 = new Pieces("W2", Color.Black, new Position(3,1));
            W3 = new Pieces("W3", Color.Black, new Position(3,2));
            W4 = new Pieces("W4", Color.Black, new Position(4,0));
            W5 = new Pieces("W5", Color.Black, new Position(4,1));
            W6 = new Pieces("W6", Color.Black, new Position(4,2));
            Empty = new Pieces();
            
            boardPieces[0] = new Pieces[3] {B1,B2,B3};
            boardPieces[1] = new Pieces[3] {B4,B5,B6}; 
            boardPieces[2] = new Pieces[1] {Empty};
            boardPieces[3] = new Pieces[3] {W4,W5,W6};
            boardPieces[4] = new Pieces[3] {W1,W2,W3};  
        }

        public bool End
        {
            get
            {
                return true;
            }
        }
        //recebe as coordenadas e vai pedir nome à posições
        public string GetPieceName( Position pos )
        {
            return boardPieces[pos.Row][pos.Col].name;
            
        }

        public bool MakeMove(Pieces pieces, Position pos)
        {
            if(boardPieces[pos.Row][pos.Col] == Empty)
            {
                
                boardPieces[pos.Row][pos.Col] = pieces;
                turn ++;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //public void GetChosenPiece()

        

        /*public Board MovePiece ( Board boardPieces)
        {
            B1= board[4][0];
        }*/
    

    }
}