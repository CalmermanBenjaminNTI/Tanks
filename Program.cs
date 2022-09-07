// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Linq;
using Raylib_cs;
using System.Numerics;

namespace Tanks // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// <summary>
        /// Writes one letter at a time
        /// </summary>
        /// <param name="text"></param>
        static void TypeWrite(string text)
        {
            foreach (char a in text)
            {
                Console.Write(a);
                System.Threading.Thread.Sleep(100);                
            }
        }
        
        /// <summary>
        /// Runs the typical behaviour of bullets
        /// </summary>
        /// <param name="bullets"></param>
        static void RunBullet(ref List<Vector4> bullets)
        {
            List<Vector4> newBullets = new List<Vector4>();
            foreach (var bullet in bullets)
            {
                newBullets.Add(new Vector4(
                bullet.W+bullet.Y,
                bullet.X+bullet.Z,
                bullet.Y,
                bullet.Z
                ));
            }
            bullets = new List<Vector4>(newBullets);
            foreach (var bullet in bullets)
            {
                Raylib.DrawTriangle(bullet.Z/bullet.Y);
            }
        }

        static void Main(string[] args)
        {
            TypeWrite("Hello World!");

            while(!Raylib.WindowShouldClose())
            {
                
            }
        }
    }
}