
namespace Projeto2
{
    public class Board
    {
        //Creates an array of arrays of the class pieces
        private Pieces [][] boardPieces = new Pieces[5][];
        //Instances of pieces of class Pieces
        private Pieces B1,B2,B3,B4,B5,B6,W1,W2,W3,W4,W5,W6,Empty;
        //Instance of the turn counter
        private int turn ;
        /// <summary>
        /// Constructor and creates the board and pieces 
        /// </summary>
        public Board()
        {
            //pieces
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
            //board
            boardPieces[0] = new Pieces[3] {B1,B2,B3};
            boardPieces[1] = new Pieces[3] {B4,B5,B6};
            boardPieces[2] = new Pieces[1] {Empty};
            boardPieces[3] = new Pieces[3] {W4,W5,W6};
            boardPieces[4] = new Pieces[3] {W1,W2,W3};
            turn = 0 ; 
        }

        //Gives the turn
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

        //Checks if the game endend
        public bool End
        {
            get
            {
                return BlackWin || WhiteWin;
            }
        }

        //Checks if Black pieces won
        public bool BlackWin
        {
            get
            {
                //Goes throw all the board array
                for(int i = 0; i < boardPieces.Length; i++)
                {
                    for(int j = 0 ; j < boardPieces[i].Length; j++)
                    {
                        //Checks if there are any piece diferent of empty or
                        //black. If it fouds returns false, which means that
                        //there are white pieces
                        if((boardPieces[i][j].color != Empty.color)
                        && (boardPieces[i][j].color != B1.color))
                            return false;
                    }
                        
                }
                return true;
            }
        }

        //Checks if White pieces won 
        public bool WhiteWin
        {
            get
            {
                //Goes throw all the board array
                for(int i = 0; i < boardPieces.Length; i++)
                {
                    for(int j = 0 ; j < boardPieces[i].Length; j++)
                    {
                        //Checks if there are any piece diferent of empty or
                        //white. If it returns false, means that
                        //there are white pieces
                        if((boardPieces[i][j].color != Empty.color) 
                        && (boardPieces[i][j].color != W1.color))
                            return false; 
                    }
                        
                }
                return true;
            }
        }
        /// <summary>
        /// Get coordinates and goes to the position of those 
        /// coordinates see the name of that piece returs a string
        /// </summary>
        /// <param name="pos">Receives a position</param>
        /// <returns>The name of that piece</returns>
        public string GetPieceName( Position pos )
        {
            return boardPieces[pos.Row][pos.Col].name;
            
        }

        /// <summary>
        /// Receives a int that means a piece of the board
        /// </summary>
        /// <param name="piece">Choice made by the player</param>
        /// <returns>The piece chosen by the player</returns>
        public Pieces GiveChosenPiece(int piece)
        {
            //Checks the turn, if its black or white turn
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

        /// <summary>
        /// This methos checks if the player can move on that direction and 
        /// Moves the piece
        /// returns true if can move return false if not
        /// </summary>
        /// <param name="pieces">Piece chosen by the player</param>
        /// <param name="nextPos">The next position chosen by the player</param>
        /// <returns>Bool that indicates if the move was made</returns>
        public bool CanMove(Pieces pieces, Position nextPos)
        {
            int diferenceInX = pieces.X - nextPos.Row;
            int diferenceInY = pieces.Y - nextPos.Col;
            //Checks if the color of the piece and the color that is in the next
            //position are the same returrs false 
            if(pieces.color == boardPieces[nextPos.Row][nextPos.Col].color)
            {
                return false;
            }
            //Checks if the of nextPos is equal to empty
            else if (boardPieces[nextPos.Row][nextPos.Col] == Empty)
            {
                //Checks if the diference between the pieces coodinates and 
                //nextPos coordinates are superior to 2 or inferior -2 
                if((diferenceInX < 2 && diferenceInX > -2) &&
                 (diferenceInY < 2 && diferenceInY > -2))
                {
                    // does the move
                    boardPieces[pieces.X][pieces.Y] = Empty;
                    pieces.X = nextPos.Row;
                    pieces.Y = nextPos.Col;
                    boardPieces[nextPos.Row][nextPos.Col] = pieces;
                    turn ++;
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }         
        }

    }
}