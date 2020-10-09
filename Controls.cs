using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    internal class Controls
    {
        public void Comandos()
        {
            ConsoleKeyInfo Key = Console.ReadKey();
            switch (Key.Key)
            {
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Right Arrow");
                    break;

                case ConsoleKey.LeftArrow:
                    Console.WriteLine("Left Arrow");
                    break;

                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down Arrow");
                    break;

                default:
                    break;
            }
        }
    }
}