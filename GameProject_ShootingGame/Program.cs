// Program.cs
using System;
using System.Collections.Generic;

namespace Gpprj2
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.CursorVisible = false;

            Player player = new Player();

            List<Enemy> enemies = new List<Enemy>
            {
                new Enemy(6, 2),
                new Enemy(18, 2),
                new Enemy(30, 2),
                new Enemy(42, 2),
                new Enemy(12, 4),
                new Enemy(24, 4),
                new Enemy(36, 4),
                new Enemy(48, 4)
            };

            while (true)
            {
                PrintScreen();

                Player.PlayerMoving(enemies);

                if (enemies.Count == 0)
                {
                    break;
                }

                Player.HitWall();
            }

            GameOver();

            void GameOver()
            {
                PrintScreen();

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, Wall.WALL_HEIGHT + 1);
                Console.WriteLine("\nGame Over! !");
            }

            void PrintScreen()
            {
                Console.Clear();

                Wall.PrintWall(Wall.WALL_WIDTH, Wall.WALL_HEIGHT);

                for (int i = 0; i < enemies.Count; i++)
                {
                    Enemy.PrintEnemy(enemies[i]);
                }

                Console.SetCursorPosition(Player.X, Player.Y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(Player.PLAYER_PLAIN);
            }
        }
    }
}