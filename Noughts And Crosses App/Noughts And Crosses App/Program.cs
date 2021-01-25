using System;

namespace Noughts_And_Crosses_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PlayGame();
            Console.WriteLine("Game over");
        }
    }
}
