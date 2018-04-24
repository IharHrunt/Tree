using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }     

    }
}
