namespace Projeto2
{
    public class Position
    {
        public int Row {get; }
        public int Col { get; }
        public int Pos {get;}

        public Position (int row, int col)
        {
            Row = row;
            Col = col;
            Pos=(row,col);
        }
    }
}