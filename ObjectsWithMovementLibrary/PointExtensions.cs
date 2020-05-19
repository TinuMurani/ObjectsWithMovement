using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsWithMovementLibrary
{
    public static class PointExtensions
    {
        public static void PrintCoordinatesToConsole(this Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Coordinates of Point[{i}]: X={ points[i].X }, Y={ points[i].Y }");
            }
        }
    }
}
