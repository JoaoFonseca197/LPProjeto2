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

        public Pieces ReadChosenPiece(Board board)
        {
            string aux;
            int peça;
            Console.WriteLine($"Jogador qual é a peça ?");
            aux = Console.ReadLine();
            peça = int.Parse(aux);
            if( board.Turn == 0)
            {
                switch (peça)
                {
                    case 1: return board.B1;
                    case 2: return board.B2;
                    case 3: return board.B3;
                    case 4: return board.B4;
                    case 5: return board.B5;
                    case 6: return board.B6;
                    default: return null;
                } 
            }
            else
            {
              switch (peça)
                {
                    case 1: return board.W1;
                    case 2: return board.W2;
                    case 3: return board.W3;
                    case 4: return board.W4;
                    case 5: return board.W5;
                    case 6: return board.W6;
                    default: return null;
                }  
            }
        }
        
        public int ReadMovement()
        {
            string aux;
            int move;
            Console.WriteLine($"Jogador qual é a movimento ?");
            aux = Console.ReadLine();
            move = int.Parse(aux);
            return move;
        }

        public void RenderMessage(string str)
        {
            Console.WriteLine(str);
        } 

    }
}

