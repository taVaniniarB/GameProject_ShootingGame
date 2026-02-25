// Bullet.cs
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Gpprj2
{
    class Bullet
    {
        public static int Damage;

        public int BulletX;
        public int BulletY;

        private const string BULLET = "!";

        public Bullet(int x, int y, int damage)
        {
            BulletX = x + Player.PLAYER_PLAIN.Length / 2;
            BulletY = y;
            Damage = damage;
        }

        public static void BulletMove(Bullet bullet, List<Enemy> enemies)
        {
            for (int i = 1; i <= Wall.WALL_HEIGHT; i++)
            {
                bullet.BulletY--;

                HitEnemy(enemies);

                if (bullet.BulletY > 0)
                {
                    PrintBullet(bullet);
                    EraseBullet(bullet);
                }
            }
        }

        public static void PrintBullet(Bullet bullet)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(bullet.BulletX, bullet.BulletY);
            Console.Write(BULLET);
        }

        public static void EraseBullet(Bullet bullet)
        {
            for (int i = 0; i < Wall.WALL_HEIGHT; i++)
            {
                if (bullet.BulletY + 1 != Player.Y)
                {
                    Console.SetCursorPosition(bullet.BulletX, bullet.BulletY + 1);
                    Console.Write(" ");
                }
            }
        }

        static void HitEnemy(List<Enemy> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (Player.bullets.Count != 0)
                {
                    if (Player.bullets[0].BulletY == enemies[i].EnemyY &&
                        (Player.bullets[0].BulletX >= enemies[i].EnemyX &&
                         Player.bullets[0].BulletX <= enemies[i].EnemyX + Enemy.MOB.Length - 1))
                    {
                        enemies[i].Hp -= Damage;

                        if (enemies[i].Hp <= 0)
                        {
                            enemies[i].IsAlive = false;
                            enemies.RemoveAt(i);
                        }
                    }
                }
            }
        }
    }
}