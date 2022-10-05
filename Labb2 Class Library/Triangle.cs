using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Class_Library
{
    public class Triangle: Shape2D
    {
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        private Vector2 centroid;
        public override float Area
        {
            get
            {
                float a = (p1.X * (p2.Y - p3.Y)) + (p2.X * (p3.Y - p1.Y)) + (p3.X * (p1.Y - p2.Y)) / 2;
                return Math.Abs(a);
            }
        }
        public override float Circumference
        {
            get
            {
                
                float side1 = (float)Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
                float side2 = (float)Math.Sqrt((p1.X - p3.X) * (p1.X - p3.X) + (p1.Y - p3.Y) * (p1.Y - p3.Y));
                float side3 = (float)Math.Sqrt((p2.X - p3.X) * (p2.X - p3.X) + (p2.Y - p3.Y) * (p2.Y - p3.Y));

                return side1 + side2 + side3;
            }
        }
        public override Vector3 Center
        {
            get
            {
                Vector3 c = new Vector3(centroid, (float)0);
                return c;
            }
        }

        public override string ToString()
        {
            return $"triangle @({centroid.X}, {centroid.Y}): p1({p1.X}, {p1.Y}), p2({p2.X}, {p2.Y}), p3({p3.X}, {p3.Y})";

        }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.centroid = new Vector2((p1.X + p2.X + p3.X) / 3, (p1.Y + p2.Y + p3.Y) / 3);
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
    }
}
