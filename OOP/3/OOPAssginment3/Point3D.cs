using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Point3D : IComparable, ICloneable
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D(double x, double y) : this(x, y, 0)
        {
        }

        public Point3D(double x) : this(x, 0, 0)
        {
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Point3D otherPoint =(Point3D) obj ;
            if (otherPoint != null)
            {
                int result = X.CompareTo(otherPoint.X);
                if (result == 0)
                {
                    result = Y.CompareTo(otherPoint.Y);
                }
                return result;
            }
            else
            {
                throw new ArgumentException("Object is not a Point3D");
            }
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, p2))
                return true;
            if (p1 is null || p2 is null)
                return false;

            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }
    }
}
