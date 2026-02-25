// Player.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gpprj2
{
    class Player
    {
        public static List<Bullet> bullets = new List<Bullet>();

        public const string PLAYER_PLAIN = ">-0-<";

        public static int X = Wall.WALL_WIDTH / 2;
        public static int Y = Wall.WALL_HEIGHT / 2;

        public static void PlayerMoving(List<Enemy> enemies)
        {
            if (NativeKeyboard.IsKeyDown(EKeyCode.Left))
            {
                X--;
            }

            if (NativeKeyboard.IsKeyDown(EKeyCode.Right))
            {
                X++;
            }

            if (NativeKeyboard.IsKeyDown(EKeyCode.Up))
            {
                Y--;
            }

            if (NativeKeyboard.IsKeyDown(EKeyCode.Down))
            {
                Y++;
            }

            if (NativeKeyboard.IsKeyDown(EKeyCode.Space))
            {
                Shoot(enemies);
            }

            Thread.Sleep(10);
        }

        public static void HitWall()
        {
            if (X <= 0)
            {
                X++;
            }

            if (X > Wall.WALL_WIDTH - PLAYER_PLAIN.Length)
            {
                X--;
            }

            if (Y < 0)
            {
                Y++;
            }

            if (Y > Wall.WALL_HEIGHT - 1)
            {
                Y--;
            }
        }

        public static void Shoot(List<Enemy> enemies)
        {
            bullets.Add(new Bullet(X, Y, 1));
            Bullet.BulletMove(bullets[0], enemies);
            bullets.RemoveAt(0);
        }
    }
}