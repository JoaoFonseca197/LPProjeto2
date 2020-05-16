namespace Projeto2
{
    /// <summary>
    /// Converts 2 int's into a Position
    /// </summary>
    public class Position
    {
        public int Row {get; }
        public int Col { get; }

        public Position (int row, int col)
        {
            Row = row;
            Col = col;
            
        }
    }
}