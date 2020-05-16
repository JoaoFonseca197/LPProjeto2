namespace Projeto2
{
    /// <summary>
    /// Used to create the board and the pieces
    /// </summary>
    public class Pieces
    {
        public string name {get; } 
        public Color color {get; }
        public int X{get; set;}
        public int Y{get; set;}

        /// <summary>
        /// Constructor that receives a name color and to int's 
        /// (symbolizes the coordinates)
        /// </summary>
        /// <param name="name">A string </param>
        /// <param name="color">A enum only can have three choices</param>
        /// <param name="x">Value in a Row</param>
        /// <param name="y">Value in a Colum</param>
        public Pieces (string name, Color color, int x, int y)
        {
            this.name = name;
            this.color = color;
            X = x;
            Y = y;
        }

       /// <summary>
       /// Constructor of the empty spaces/pieces
       /// </summary>
        public Pieces ()
        {
            name = " ";
            color = Color.Empty;
        }
    }
}