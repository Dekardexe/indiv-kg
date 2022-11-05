using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Vector
    {
        Point a;
        Point b;
        double x;
        double y;
        public Vector(Point a, Point b)
        {
            this.a = a;
            this.b = b;
            x = b.X - a.X;
            y = b.Y - a.Y;
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        { 
            return x;
        }
        public double GetY()
        {
            return y;
        }

        public void SetPoints(Point a, Point b)
        {
            this.a = a;
            this.b = b;
            x = b.X - a.X;
            y = b.Y - a.Y;
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public static Vector operator *(double k, Vector v1)
        {
            return new Vector(v1.x * k, v1.y*k);                              
        }

        public static double operator *(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return v1 + (-1 * v2);
        }        
    }
}
