using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsWithMovementLibrary
{
    public class Triangle : IGeometricalShape
    {
        public Point[] GeometricalObjectExtremities { get; }

        public Triangle(Point[] lineExtremities)
        {
            if (lineExtremities.Length is 3)
            {
                this.GeometricalObjectExtremities = lineExtremities;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"A triangle has to be defined by three Points. Your value [{ lineExtremities.Length }] does not correspund");
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
            GeometricalObjectExtremities.PrintCoordinatesToConsole();
        }
    }
}
