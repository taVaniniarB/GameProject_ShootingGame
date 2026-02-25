// Wall.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Gpprj2
{
    class Wall
    {
        public const int WALL_WIDTH = 64;
        public const int WALL_HEIGHT = 20;

        public static void PrintWall(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.White;

            // 왼쪽 벽
            for (int i = 0; i <= y; i++)
            {
                Console.WriteLine("|");
            }

            // 오른쪽 벽
            for (int i = 0; i <= y; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.WriteLine("|");
            }

            // 아래 바닥
            for (int i = 1; i < x; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.WriteLine("-");
            }
        }
    }
}