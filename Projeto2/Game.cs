
namespace Projeto2
{
    /// <summary>
    /// Game Class creates a board and a UserInterface

    /// </summary>
    public class Game
    {
        //Instance of the board
        private Board board;
        //Instance of the UI
        private UserInterface ui;
        /// <summary>
        /// Constructor  
        /// Creates a board and UI
        /// </summary>
        public Game()
        {
            board = new Board();
            ui = new UserInterface();
        }

        /// <summary>
        /// This methos is main loop of the game
        /// </summary>
        public void Play()
        {
            // Goes to the class UserInterface and calls the PrintRules() method
            ui.PrintRules();
            //Circle that only ends if the condition board.End == true
            do
            {
                Pieces piece;
                Position nextMovePos;
                int move;
                int numPiece = 0;

                //Goes to the class UserInterface
                //and calls the PrintRules() method and gives the board as 
                //parameter
                ui.PrintBoard(board);

                //Prints the player's turn and asks the player what piece that
                //he wants gives returns a int
                //Gives board.Turn to decide what message to print
                numPiece = ui.AskForChosenPiece(board.Turn);

                //Converts the number yo a piece of the board
                piece = board.GiveChosenPiece(numPiece);
                
                //asks the player what movement he wants returns a int
                move = ui.ReadMovement();

                //Converts the move into a position
                nextMovePos = ConvertToPos(move);

                //Checks if the movement is valid if it is does the move
                if(!board.CanMove(piece, nextMovePos))
                {
                    //if movement not valid prints the message below
                    ui.RenderMessage("This is not a legal move");
                }
            }while(!board.End);

            //prints the winner
            ui.RenderWinner(board);
        }

        /// <summary>
        /// Receive an int and convert to a position. 
        /// each number means a position
        /// </summary>
        /// <param name="num">Choice of the player </param>
        /// <returns>returns a Position of the class Position</returns>
        public Position ConvertToPos(int move)
        {
            switch (move)
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