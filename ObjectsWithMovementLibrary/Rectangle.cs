using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsWithMovementLibrary
{
    public class Rectangle : IGeometricalShape
    {
        public Point[] GeometricalObjectExtremities { get; }

        public Rectangle(Point lowerLeftCornerPoint, int width, int height)
        {
            if (width > 0 && height > 0)
            {
                Point upperLeftCornerPoint = new Point { X = lowerLeftCornerPoint.X, Y = lowerLeftCornerPoint.Y + height };
                Point upperRightCornerPoint = new Point { X = upperLeftCornerPoint.X + width, Y = upperLeftCornerPoint.Y };
                Point lowerRightCornerPoint = new Point { X = lowerLeftCornerPoint.X + width, Y = lowerLeftCornerPoint.Y };

                GeometricalObjectExtremities = new Point[]
                {
                lowerLeftCornerPoint,
                upperLeftCornerPoint,
                upperRightCornerPoint,
                lowerRightCornerPoint
                };
            }
            else
            {
                throw new ArgumentOutOfRangeException("Rectangle's width and height must be greater than 0.");
            }
        }

        public void MoveOnX(int distance)
        {
            for (int i = 0; i < GeometricalObjectExtremities.Length; i++)
            {
                GeometricalObjectExtremities[i].X += distance;
            }
        }

        public void MoveOnY(int distance)
        {
            for (int i = 0; i < GeometricalObjectExtremities.Length; i++)
            {
                GeometricalObjectExtremities[i].Y += distance;
            }
        }

        public void PrintCoordinates()
        {
            GeometricalObjectExtremities.PrintCoordinatesToConsole(GeometricalObjectType.Rectangle);
        }
    }
}
