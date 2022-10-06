using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Class_Library
{
    public class Circle: Shape2D
    {
        private float radius;
        private Vector2 center;
        public override float Circumference
        {
            get
            {
                return Math.Abs(2 * (float)Math.PI * radius);
            }
        }
        public override float Area
        {
            get
            {
                return (radius * radius) * (float)Math.PI;
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

        public override string ToString()
        {
            return $"circle @({center.X}, {center.Y}): r = {radius}";
        }

        public Circle(Vector2 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
    }
}
