using System;

namespace OneTetris
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tetris!\nPlease insert your name.");
            string playerName = Console.ReadLine();

            var newGame = new Game();

            newGame.StartGame(playerName);
        }
    }
}