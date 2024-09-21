using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBox
{
    public class Triangle : Shape
    {
        public required double Side1 { get; init; }
        public required double Side2 { get; init; }
        public required double Side3 { get; init; }

        private bool IsValidTriangle(double side1, double side2, double side3) => (side1 <= side2 + side3) && (side2 <= side3 + side1) && (side3 <= side1 + side2);
        private (double max, double middle, double min) GetSideLenght()
        {
            double[] arr = { Side1, Side2, Side3};// Выделение памяти, которую можно избежать прямым сравнением сторон
            Array.Sort(arr); // но так компакнее и понятнее
            return (arr[2], arr[1], arr[0]);
        }
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            if (Side1 == 0 && Side2 == 0 && Side3 == 0) return false; //вырожденный треугольник
            double max = 0, min = 0, mid = 0;
            (max , mid, min) = GetSideLenght();
            return max * max == min * min + mid * mid; //возможны ошибки округления double
        }

        public override double GetSquare() => 0.25 * Math.Sqrt((Side1 + Side2 + Side3) * (Side1 + Side2 - Side3) * (Side1 + Side3 - Side2) * (Side2 + Side3 - Side1));

        [SetsRequiredMembers]
        public Triangle(double side1, double side2, double side3)
        {
            if (!Helpers.IsValidPositiveDouble(side1)) throw new ArgumentException($"Incorrect parameter {nameof(side1)} value");
            if (!Helpers.IsValidPositiveDouble(side2)) throw new ArgumentException($"Incorrect parameter {nameof(side2)} value");
            if (!Helpers.IsValidPositiveDouble(side3)) throw new ArgumentException($"Incorrect parameter {nameof(side3)} value");
            if (!IsValidTriangle(side1, side2, side3)) throw new ArgumentException("Invalid triangle");
            Side1 = side1; Side2 = side2; Side3 = side3;
        }

        [SetsRequiredMembers]
        public Triangle() { }
    }
}
