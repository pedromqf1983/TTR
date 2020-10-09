using System;
using Utilities;

namespace OneTetris
{
    public class Game
    {
        public int speed = 1;
        public float score = 0;
        public float lines = 0;

        public void StartGame(string playerName)
        {
            Console.WriteLine($"Good luck {playerName}!\nPress space to start the game.");

            var gameArea = new GameArea();

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();

                gameArea.DrawGrid();
                UpdateGame();
            }
            else if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
        }

        public void UpdateGame()
        {
            var peca = new Pecas();
            bool completeLine = false;
            bool gameOver = false;
            bool overboard = false;

            //peca.RandomPiece();

            while (!gameOver)
            {
                if (completeLine)
                {
                    score = UpdateScore(score, lines);
                }

                if (overboard)
                {
                    gameOver = true;
                }
            }

            GameOver(Convert.ToInt32(score));

            Console.Read();
        }

        public float UpdateScore(float currentScore, float numLinhas)
        {
            currentScore += (MathF.Pow(numLinhas, 2) * 100);

            Console.SetCursorPosition(25, 5);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Score: {currentScore}");
            Console.ResetColor();

            return currentScore;
        }

        public void GameOver(int finalScore)
        {
            Console.Clear();
            Console.Write($"Game Over!\nYour final score was: {finalScore}\n\nPress space to restart.");
            var gameArea = new GameArea();

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();

                gameArea.DrawGrid();
                UpdateGame();
            }
        }
    }
}