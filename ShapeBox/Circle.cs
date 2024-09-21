using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBox
{
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public required double Radius { get; init; }

        public override double GetSquare() => Radius * Radius * Math.PI;


        [SetsRequiredMembers]
        public Circle(double radius)
        {
            if (!Helpers.IsValidPositiveDouble(radius)) throw new ArgumentException($"Incorrect parameter {nameof(radius)} value");
            Radius = radius;
        }

        [SetsRequiredMembers]
        public Circle() { }
    }
}
