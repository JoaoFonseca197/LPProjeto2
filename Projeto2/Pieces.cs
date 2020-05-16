namespace Projeto2
{
    public class Pieces
    {
        public string name {get; } 
        public Color color {get; }
        public int X{get; set;}
        public int Y{get; set;}

        //cada peça é criada com um nome e pos (o num vai dar as coordenas)
        public Pieces (string name, Color color, int x, int y)
        {
            this.name = name;
            this.color = color;
            X = x;
            Y = y;
        }

        //caso de espaço em branco
        public Pieces ()
        {
            name = " ";
        }
    }
}