using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsWithMovementLibrary
{
    public interface IGeometricalShape : IMoveObjectOnX, IMoveObjectOnY
    {
        Point[] GeometricalObjectExtremities { get; }

        void PrintCoordinates();
    }
}
