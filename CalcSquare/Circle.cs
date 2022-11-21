using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSquare
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public const double RadiusMin = 1e-6;

        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius - RadiusMin < IFigure.accuracy)
                throw new ArgumentException("Wrong value for radius.", nameof(radius));
            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
