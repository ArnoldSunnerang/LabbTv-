﻿using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Labb2_Class_Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        private static Vector2 RandomVector2()
            {
                Random rnd = new Random();
                float randomX = (float)rnd.Next(0,100);
                float randomY = (float)rnd.Next(0,100);

                Vector2 outVector = new Vector2(randomX, randomY);
                return outVector;
            }
        private static Vector3 RandomVector3()
                {
                    Random rnd = new Random();
                    float randomX = (float)rnd.Next(0,100);
                    float randomY = (float)rnd.Next(0,100);
                    float randomZ = (float)rnd.Next(0,100);

                    Vector3 outVector = new Vector3(randomX, randomY, randomZ);
                    return outVector;
                }
        
        public static Shape GenerateShape()
        {
            return GenerateShape(RandomVector3());
        }

        public static Shape GenerateShape(Vector3 center)
        {
            Vector2 center2D = new Vector2();
            center2D.X = center.X;
            center2D.Y = center.Y;
            Vector3 center3D = new Vector3();
            center3D = center;
            
            Random rnd = new Random();
            int randomShape = (int)rnd.Next(0, 6);

            if (randomShape == 0)
            {
                Circle circle = new Circle(center2D, RandomVector2().X);
                return circle;
            }
            else if (randomShape == 1)
            {
                Rectangle rectangle = new Rectangle(center2D, RandomVector2());
                return rectangle;
            }
            else if (randomShape == 2)
            {
                Rectangle square = new Rectangle(center2D, RandomVector2().X);
                return square;
            }
            else if (randomShape == 3)
            {
                Vector2 p1 = RandomVector2();
                Vector2 p2 = RandomVector2();
                Vector2 p3 = new((center2D.X * 3) - (p1.X + p2.X), (center2D.Y * 3) - (p1.Y + p2.Y));

                Triangle triangle = new Triangle(p1, p2, p3);
                return triangle;

            }
            else if (randomShape == 4)
            {
                Cuboid cuboid = new Cuboid(center3D, RandomVector3());
                return cuboid;
            }
            else if (randomShape == 5)
            {
                Cuboid cube = new Cuboid(center3D, RandomVector3().X);
                return cube;
            }
            else 
            {
                Sphere sphere = new Sphere(center3D, RandomVector3().X);
                return sphere;
            }
            
            


        }
        



    }
}