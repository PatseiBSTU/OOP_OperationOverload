using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(7, 10);
            if (!startPoint.Equals(endPoint)) Console.WriteLine($" {startPoint} to {endPoint} - it's line");
            else Console.WriteLine($" {startPoint} to {endPoint} - it's point");
            startPoint++;
            Console.WriteLine($"{startPoint} is result of ++");

            Console.WriteLine($"{endPoint--} is result of --");

            Point newPoint = new Point(34, -56);
            Point rezultPlusPoint = newPoint + startPoint;
            Console.WriteLine($"{newPoint} +{ startPoint} = {rezultPlusPoint}");

            rezultPlusPoint += newPoint ;
            Console.WriteLine($"{rezultPlusPoint} + { startPoint} = {rezultPlusPoint}");

            Point rezultFloatPlusPoint = 3.56f + newPoint;
            Console.WriteLine($" 3.56 + {newPoint} = {rezultFloatPlusPoint}");

            Console.WriteLine(newPoint > rezultFloatPlusPoint);
            Console.WriteLine(newPoint < rezultFloatPlusPoint);

            if (newPoint) Console.WriteLine($" {newPoint} is true");
            else Console.WriteLine($" {newPoint} is false");

            Console.WriteLine(newPoint + " => to int  " + (int)newPoint);

            Console.WriteLine(newPoint + " => to Point3D  " + (Point3D)newPoint);

            Point3D point3D = new Point3D(6,-45,7);
            Console.WriteLine(point3D + " => to Point  " + (Point)point3D);
        }
    }
}
