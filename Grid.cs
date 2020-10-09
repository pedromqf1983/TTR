using System;

namespace Utilities
{
    public class GameArea
    {
        private readonly int largura = 20;
        private readonly int altura = 10;
        private readonly int locationX = 0;
        private readonly int locationY = 0;

        public void DrawGrid()
        {
            string s = "╔";
            string space = "";
            string temp = "";

            for (int i = 0; i < largura; i++)
            {
                space += " ";
                s += "═";
            }
            for (int j = 0; j < locationX; j++)
                temp += " ";
            s += "╗" + "\n";
            for (int i = 0; i < altura; i++)
                s += temp + "║" + space + "║" + "\n";
            s += temp + "╚";
            for (int i = 0; i < largura; i++)
                s += "═";
            s += "╝" + "\n";

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.CursorTop = locationY;
            Console.CursorLeft = locationX;
            Console.Write(s);
            Console.ResetColor();

            Console.SetCursorPosition(25, 5);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Score: {0}");
            Console.ResetColor();
        }
    }
}