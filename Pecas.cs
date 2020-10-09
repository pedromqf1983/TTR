using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class Pecas
    {
        public void RandomPiece()
        {
            var random = new Random();

            var pieceNumber = random.Next(0, 2);

            ChoosePiece(pieceNumber);
        }

        public void ChoosePiece(int random)
        {
            switch (random)
            {
                case 0:
                    Line();
                    break;

                case 1:
                    Square();
                    break;
            }
        }

        public void Line()
        {
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("@", Console.ForegroundColor = ConsoleColor.Red);
            }
        }

        public void Square()
        {
            int n = 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("@");

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("@");
                }
            }
        }
    }
}