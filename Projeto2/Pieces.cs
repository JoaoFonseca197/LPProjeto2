namespace Projeto2
{
    public class Pieces
    {
        public string name ;
        public Color color ;


        public Position pos;

        public Pieces (string name, Color color, int num)
        {
            this.name = name;
            this.color = color;
            this.pos = Position(num);
        }

        public Pieces ()
        {
            name = " ";
        }

        public string GetName() => name;

        private Position Position (int num)
        {
            switch (num)
            {
                case 1: return new Position (0,0);
                case 2: return new Position (0,1);
                case 3: return new Position (0,2);
                case 4: return new Position (1,0);
                case 5: return new Position (1,1);
                case 6: return new Position (1,2);
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