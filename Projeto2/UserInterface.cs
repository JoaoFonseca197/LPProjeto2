using System;
namespace Projeto2
{
    public class UserInterface
    {
        //imprime o tabuleiro
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

        public int AskForChosenPiece(int turn)
        {
            string aux;
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
        
        public int ReadMovement()
        {
            string aux;
            int move;
            Console.WriteLine($"What's your Play ?");
            aux = Console.ReadLine();
            move = int.Parse(aux);
            return move;
        }

        public void RenderMessage(string str)
        {
            Console.WriteLine(str);
        } 

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

    }
}

