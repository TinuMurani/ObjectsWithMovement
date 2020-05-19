using System;

namespace ObjectsWithMovementLibrary
{
    public class Line : IGeometricalShape
    {
        public Point[] GeometricalObjectExtremities { get; }

        public Line(Point[] lineExtremities)
        {
            if (lineExtremities.Length is 2)
            {
                this.GeometricalObjectExtremities = lineExtremities;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"A line has to be defined by two Points. Your value [{ lineExtremities.Length }] does not correspund");
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
            GeometricalObjectExtremities.PrintCoordinatesToConsole(GeometricalObjectType.Line);
        }
    }
}
