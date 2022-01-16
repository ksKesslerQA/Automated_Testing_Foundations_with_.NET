using System;

namespace Interfaces_and_abstract_classes
{
    public struct Coords
    {
        public Coords(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public override string ToString() => $"({X}, {Y}, {Z})";


        public static double Distance(Coords p1, Coords p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X)
                             + (p1.Y - p2.Y) * (p1.Y - p2.Y)
                             + (p1.Z - p2.Z) * (p1.Z - p2.Z));
        }
    }
}
