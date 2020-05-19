using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsWithMovementLibrary
{
    public static class PointExtensions
    {
        public static void PrintCoordinatesToConsole(this Point[] points, GeometricalObjectType type)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"{ type } Coordinates of Point[{i}]: X={ points[i].X }, Y={ points[i].Y }");
            }
            Console.WriteLine("");
        }
    }
}
