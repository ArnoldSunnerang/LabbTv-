using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Class_Library
{
    public class Rectangle: Shape2D
    {
        private Vector2 center;
        private float height;
        private float width;
        public override float Area
        {
            get
            {
                return width * height;
            }
        }
        public override float Circumference
        {
            get
            {
                return (height * 2) + (width * 2);
            }
        }

        public override Vector3 Center
        {
            get
            {
                Vector3 c = new Vector3(center, (float)0);
                return c;
            }
        }

        public bool IsSquare
        {
            get
            {
                if (height == width)
                {
                    return true; 
                }
                else
                {
                    return false;
                }

            }
        }

        public override string ToString()
        {
            
                return $"{(this.IsSquare ? "square" : "rectangle")} @({center.X}, {center.Y}): height = {height}, width = {width}";

            
            
        }

        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.height = size.Y;
            this.width = size.X;
        }

        public Rectangle(Vector2 center, float width)
        {
            this.center = center;
            this.width = width;
            this.height = width;
        }
    }
}
