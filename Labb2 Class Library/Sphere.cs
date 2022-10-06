using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Class_Library
{
    public class Sphere: Shape3D
    {
        private Vector3 center;
        private float radius;
        public override float Volume
        {
            get
            {
                return Math.Abs((((float)1/3) + 1) * ((float)Math.PI) * (radius * radius * radius)); 
            }
        }
        public override Vector3 Center
        {
            get
            {
                return center;
            }
        }
        public override float Area
        {
            get
            {
                return Math.Abs(4 * (float)Math.PI * (radius * radius));
            }
        }

        public override string ToString()
        {
            return $"sphere @({center.X}, {center.Y}, {center.Z}): r = {radius}";
        }

        public Sphere(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }


    }
}
