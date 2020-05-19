using ObjectsWithMovementLibrary;
using System;

namespace ObjectsWithMovementConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeometricalShape line = new Line(new Point[]
            {
                new Point { X = 2, Y = 3},
                new Point { X = 7, Y = 9}
            });

            IGeometricalShape triangle = new Triangle(new Point[]
            {
                new Point { X = 1, Y = 2},
                new Point { X = 4, Y = 7},
                new Point { X = 2, Y = 1}
            });

            IGeometricalShape rectangle = new Rectangle(new Point { X = 3, Y = 1 }, 5, 4);

            GeometryUtils.CalculatePerimeter(line);
            GeometryUtils.CalculatePerimeter(triangle); 
            GeometryUtils.CalculatePerimeter(rectangle);

            Console.WriteLine("");
            Console.WriteLine("Initial coordinates:", Console.ForegroundColor = ConsoleColor.Green);
            line.PrintCoordinates();
            triangle.PrintCoordinates();
            rectangle.PrintCoordinates();

            GeometryUtils.MoveGeometricalObjectsOnX(new IGeometricalShape[]
            {
                line,
                triangle,
                rectangle
            }, 3);

            Console.WriteLine("Coordinates after movement on X axis:", Console.ForegroundColor = ConsoleColor.Cyan);
            line.PrintCoordinates();
            triangle.PrintCoordinates();
            rectangle.PrintCoordinates();

            GeometryUtils.MoveGeometricalObjectsOnY(new IGeometricalShape[]
            {
                line,
                triangle,
                rectangle
            }, 5);

            Console.WriteLine("Coordinates after movement on Y axis:", Console.ForegroundColor = ConsoleColor.Magenta);
            line.PrintCoordinates();
            triangle.PrintCoordinates();
            rectangle.PrintCoordinates();

            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
