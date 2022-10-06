using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Class_Library
{
    public class Cuboid: Shape3D
    {
        private float height;
        private float width;
        private float depth;
        private Vector3 center;
        public override float Area
        {
            get
            {
                float xy = width * height;
                float xz = width * depth;
                float yz = height * depth;
                return Math.Abs((xy + xz + yz) * 2);
            }
        }

        public override Vector3 Center
        {
            get
            {
                return center;
            }
        }

        public override float Volume
        {
            get
            {
                return Math.Abs(height * width * depth);
            }
        }

        public bool IsCube
        {
            get
            {
                if ((height == width) & (width == depth))
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
            return $"{(this.IsCube ? "cube" : "cuboid")} @({center.X}, {center.Y}, {center.Z}): height = {height}, width = {width}, depth = {depth}";
        }
        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            this.width = width;
            height = width;
            depth = width;
        }
        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            width = size.X;
            height = size.Y;
            depth = size.Z;
        }
    }
}
