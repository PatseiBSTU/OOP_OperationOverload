using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Point
    {
        float x;
        float y;

        public Point ()
        {
            x = 0;
            y = 0;
        }
        public Point(float x) : this ()
        {
            this.x = x;
           
        }
        public Point(float a, float b) 
        {
            this.x = a;
            this.y = b;

        }
        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;

        }

      

        public override string ToString()
        {
            return $"({x} , {y})";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Point)) return false;
            else
            {
                Point temp = obj as Point;
                if (temp.x == x && temp.y == y) return true;
                else return false;
            }
        }
        // префикс
        public static Point operator ++(Point point)
        {
            point.x++;
            point.y++;
            return point;

        }
        //постфикс
        public static Point operator --(Point point)
        {
            Point temp = new Point(point);
            point.x--;
            point.y--;
            return temp;
           
        }
        public static bool operator ==(Point pointA, Point pointB) => pointA.Equals(pointB);
        public static bool operator !=(Point pointA, Point pointB) => !pointA.Equals(pointB);
        public static Point operator +(Point point, float a) => new Point(point.x + a, point.y + a);
        public static Point operator +(Point b, Point a) => new Point(b.x + a.x, b.y + a.y);
        public static Point operator +(float a, Point point) => new Point(point.x + a, point.y + a);

        public static bool operator <(Point a, Point b) => a.x < b.x;
        public static bool operator >(Point a, Point b) => a.x > b.x;
        public static bool operator true(Point a) => a.x > 0 && a.y > 0;
        public static bool operator false(Point a) => a.x <= 0 || a.y <= 0;

        public static explicit operator int (Point a) => (int)(a.x+a.y);
        public static implicit operator Point3D (Point a) => new Point3D(a.x,a.y,0);
        public static explicit operator Point(Point3D a) => new Point(a.X, a.Y);
    }
}
