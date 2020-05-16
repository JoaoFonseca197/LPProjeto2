using System;
namespace Projeto2
{
    public class Board
    {
        //cria um array de arrays
        private Pieces [][] boardPieces = new Pieces[5][];
        //completa o tabuleiro com as peças
        private Pieces B1,B2,B3,B4,B5,B6,W1,W2,W3,W4,W5,W6,Empty;

        public int turn = 0 ;
        public Board()
        {
            B1 = new Pieces("B1", Color.Black,0,0);
            B2 = new Pieces("B2", Color.Black,0,1);
            B3 = new Pieces("B3", Color.Black,0,2);
            B4 = new Pieces("B4", Color.Black,1,0);
            B5 = new Pieces("B5", Color.Black,1,1);
            B6 = new Pieces("B6", Color.Black,1,0);
            W1 = new Pieces("W1", Color.White,4,0);
            W2 = new Pieces("W2", Color.White,4,1);
            W3 = new Pieces("W3", Color.White,4,2);
            W4 = new Pieces("W4", Color.White,3,0);
            W5 = new Pieces("W5", Color.White,3,1);
            W6 = new Pieces("W6", Color.White,3,2);
            Empty = new Pieces();
            
            boardPieces[0] = new Pieces[3] {B1,B2,B3};
            boardPieces[1] = new Pieces[3] {B4,B5,B6}; 
            boardPieces[2] = new Pieces[1] {Empty};
            boardPieces[3] = new Pieces[3] {W4,W5,W6};
            boardPieces[4] = new Pieces[3] {W1,W2,W3};  
        }

        public int Turn
        {
            get
            {
                // 0 = Black
                // 1 = White
                if (turn % 2 == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
                
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

        public Pieces GiveChosenPiece(int piece)
        {
            if( Turn == 0)
            {
                switch (piece)
                {
                    case 1: return B1;
                    case 2: return B2;
                    case 3: return B3;
                    case 4: return B4;
                    case 5: return B5;
                    case 6: return B6;
                    default: return null;
                } 
            }
            else
            {
                switch (piece)
                {
                    case 1: return W1;
                    case 2: return W2;
                    case 3: return W3;
                    case 4: return W4;
                    case 5: return W5;
                    case 6: return W6;
                    default: return null;
                }  
            }
        }

        public bool CanMove(Pieces pieces, Position nextPos)
        {
            int diferenceInX = pieces.X - nextPos.Row;
            int diferenceInY = pieces.Y - nextPos.Col;
            
            if(pieces.color == boardPieces[nextPos.Row][nextPos.Col].color)
            {
                return false;
            }
            else if (boardPieces[nextPos.Row][nextPos.Col] == Empty)
            {
                if((diferenceInX < 2 && diferenceInX > -2) && (diferenceInY < 2 && diferenceInY > -2))
                {
                    boardPieces[pieces.X][pieces.Y] = Empty;
                    pieces.X = nextPos.Row;
                    pieces.Y = nextPos.Col;
                    boardPieces[nextPos.Row][nextPos.Col] = pieces;
                    turn ++;
                    return true;
                }
                return false;
            }
            else()
            {
                return false;
            }         
        }
    }
}