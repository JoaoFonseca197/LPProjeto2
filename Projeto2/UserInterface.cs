using System;
namespace Projeto2
{
    public class UserInterface
    {
        //imprime o tabuleiro
        public void Print (Board board)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("--------------------------------");
                if(i == 2)
                {
                    Console.WriteLine("            |"+board.GetPieceName(2,0)+"     |");
                }
                else if (i== 0 || i == 4)
                {
                    
                    for(int j = 0; j < 3; j++)
                    {
                        Console.Write("|    "+board.GetPieceName(i,j)+"   ");
                    }
                    Console.WriteLine("  | ");

                }
                else if (i == 1 || i == 3)
                {
                    Console.Write("     ");
                    for(int j = 0; j < 3; j++)
                    {
                        Console.Write("|  "+board.GetPieceName(i,j)+"  ");
                    }
                    Console.WriteLine(" |");
                }

            }
            Console.WriteLine("--------------------------------\n");
        }
    }
}

