using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsWithMovementLibrary
{
    public static class GeometryUtils
    {
        public static void CalculatePerimeter(IGeometricalShape shape)
        {
            double perimeter = 0.0;

            if (shape is Line)
            {
                perimeter = CalculateLineLength(shape.GeometricalObjectExtremities[0], shape.GeometricalObjectExtremities[1]);
            }
            else if (shape is Triangle)
            {
                perimeter = CalculateLineLength(shape.GeometricalObjectExtremities[0], shape.GeometricalObjectExtremities[1]) +
                            CalculateLineLength(shape.GeometricalObjectExtremities[1], shape.GeometricalObjectExtremities[2]) +
                            CalculateLineLength(shape.GeometricalObjectExtremities[0], shape.GeometricalObjectExtremities[2]);
            }
            else if (shape is Rectangle)
            {
                perimeter = CalculateLineLength(shape.GeometricalObjectExtremities[0], shape.GeometricalObjectExtremities[1]) +
                            CalculateLineLength(shape.GeometricalObjectExtremities[1], shape.GeometricalObjectExtremities[2]) +
                            CalculateLineLength(shape.GeometricalObjectExtremities[2], shape.GeometricalObjectExtremities[3]) +
                            CalculateLineLength(shape.GeometricalObjectExtremities[3], shape.GeometricalObjectExtremities[0]);
            }
            else
            {
                perimeter = 0;
            }

            Console.WriteLine($"The perimeter of the { shape.GetType().Name } is: { perimeter }");
        }

        private static double CalculateLineLength(Point firstPointCoordinates, Point secondPointCoordinates)
        {
            double width = (firstPointCoordinates.X - secondPointCoordinates.X) > 0 ?
                        (firstPointCoordinates.X - secondPointCoordinates.X) :
                        (secondPointCoordinates.X - firstPointCoordinates.X);

            double height = (firstPointCoordinates.Y - secondPointCoordinates.Y) > 0 ?
                        (firstPointCoordinates.Y - secondPointCoordinates.Y) :
                        (secondPointCoordinates.Y - firstPointCoordinates.Y);

            double result = Math.Sqrt(width * width + height * height);

            return result;
        }

        public static void MoveGeometricalObjectsOnX(IGeometricalShape[] shapes, int distance)
        {
            if (shapes is null)
            {
                shapes = new IGeometricalShape[0];
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].MoveOnX(distance);
            }
        }

        public static void MoveGeometricalObjecstOnY(IGeometricalShape[] shapes, int distance)
        {
            if (shapes is null)
            {
                shapes = new IGeometricalShape[0];
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].MoveOnY(distance);
            }
        }
    }
}
