// Enemy.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Gpprj2
{
    class Enemy
    {
        public const string MOB = "[XUX]";
        public const string DEAD_MOB = " ";

        public bool IsAlive;
        public int Hp = 1;
        public int EnemyX;
        public int EnemyY;

        public Enemy(int x, int y)
        {
            IsAlive = true;
            EnemyX = x;
            EnemyY = y;
        }

        public static void PrintEnemy(Enemy enemy)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(enemy.EnemyX, enemy.EnemyY);

            if (enemy.IsAlive)
            {
                Console.Write(MOB);
            }
            else
            {
                Console.Write(DEAD_MOB);
            }
        }
    }
}