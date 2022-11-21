using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalcSquare
{
    public class Triangle : ITriangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private double eps = IFigure.accuracy;

        private readonly Lazy<bool> _isTriangleRightAngled;
        public bool IsTriangleRightAngled => _isTriangleRightAngled.Value;

        public Triangle(double A, double B, double C)
        {
            if (A < eps)
                throw new ArgumentException("Wrong value for side.", nameof(A));

            if (B < eps)
                throw new ArgumentException("Wrong value for side.", nameof(B));

            if (C < eps)
                throw new ArgumentException("Wrong value for side.", nameof(C));

            var maxSide = Math.Max(A, Math.Max(B, C));
            var perimeter = A + B + C;
            if ((perimeter - maxSide) - maxSide < IFigure.accuracy)
                throw new ArgumentException("The longest side of the triangle must be less than the sum of the other sides.");

            SideA = A;
            SideB = B;
            SideC = C;

            _isTriangleRightAngled = new Lazy<bool>(GetIsTriangleRightAngled);
        }

        public bool GetIsTriangleRightAngled()
        {
            double maxEdge = SideA, b = SideB, c = SideC;
            if (b - maxEdge > eps)
                Swap(ref maxEdge, ref b);

            if (c - maxEdge > eps)
                Swap(ref maxEdge, ref c);

            return Math.Abs(Math.Pow(maxEdge, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < eps;
        }

        public double GetSquare()
        {
            var halfP = (SideA + SideB + SideC) / 2d;
            var square = Math.Sqrt(
                halfP
                * (halfP - SideA)
                * (halfP - SideB)
                * (halfP - SideC)
            );

            return square;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
 