using System;
namespace Projeto2
{
    /// <summary>
    /// Used to Render the messages
    /// </summary>
    public class UserInterface
    {
        /// <summary>
        /// renders the board
        /// </summary>
        /// <param name="board">Board created </param>
        public void PrintBoard (Board board)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("--------------------------------");
                if(i == 2)
                {
                    Console.WriteLine("            |"+board.GetPieceName(new Position(2,0))+"     |");
                }
                else if (i== 0 || i == 4)
                {
                    
                    for(int j = 0; j < 3; j++)
                    {
                        Console.Write("|    "+board.GetPieceName(new Position(i,j))+"   ");
                    }
                    Console.WriteLine("  | ");

                }
                else if (i == 1 || i == 3)
                {
                    Console.Write("     ");
                    for(int j = 0; j < 3; j++)
                    {
                        Console.Write("|  "+board.GetPieceName(new Position(i,j))+"  ");
                    }
                    Console.WriteLine(" |");
                }

            }
            Console.WriteLine("--------------------------------\n");
        }

        /// <summary>
        /// This renders 2 messages depending of the turn 
        /// The parameter is the turn this will decide what message to print
        /// </summary>
        /// <param name="turn">Has the values ​​of 0 or 1</param>
        /// <returns>A value between 1 and 6</returns>
        public int AskForChosenPiece(int turn)
        {
            //saves the option of the player
            string aux;
            //option of the player converted to int
            int piece;
            if(turn == 0)
            {
                Console.WriteLine($"Black chose your piece");
            }
            else
            {
                Console.WriteLine($"White chose your piece");
            }
            aux = Console.ReadLine();
            piece = int.Parse(aux);
            return piece;
        }
        
        /// <summary>
        /// Asks the player whats is the next movement
        /// </summary>
        /// <returns>Int meaning the position/move</returns>
        public int ReadMovement()
        {
            string aux;
            int move;
            Console.WriteLine($"What's your Play ?");
            aux = Console.ReadLine();
            move = int.Parse(aux);
            return move;
        }

        /// <summary>
        /// Renders the message 
        /// </summary>
        /// <param name="str">Message the is give as parameter</param>
        public void RenderMessage(string str)
        {
            Console.WriteLine(str);
        } 

        /// <summary>
        /// Renders the rules
        /// </summary>
        public void PrintRules()
        {
            Console.WriteLine("\n \nWelcome to the Fellis Game !!!");
            Console.WriteLine("Underneath will be the rules");   
            Console.WriteLine("\nThe pieces only can move one house.");
            Console.WriteLine("Only can eat one piece");
            Console.WriteLine("And this are the movements");
            Console.WriteLine("1 2 3 \n4 5 6 \n  7 \n8 9 10 \n11 12 13 ");
            Console.WriteLine("HAVE FUN !!!\n");
        }

        /// <summary>
        /// Renders the winner
        /// </summary>
        /// <param name="board">The board created</param>
        public void RenderWinner(Board board)
        {
            if(board.BlackWin)
            {
                Console.WriteLine("Black Wins");
            }
            else
            {
                Console.WriteLine("White Wins");
            }
        }

    }
}

