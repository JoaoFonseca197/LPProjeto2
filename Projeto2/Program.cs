

namespace Projeto2
{
    class Program
    {
        /// <summary>
        /// Main method will instantiate a game of the Game class. 
        /// and will call the Play() method to start the game.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //instantiation of the game.
            Game game = new Game();
            //call the Play method to start the game.
            game.Play();
        }
    }
}

