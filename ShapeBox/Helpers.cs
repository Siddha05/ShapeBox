using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBox
{
    internal static class Helpers
    {
        /// <summary>
        /// Проверяет, является ли <paramref name="value"/> допустимым положительным значением 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsValidPositiveDouble(double value)
        {
            if (double.IsNaN(value) && double.IsInfinity(value) && double.IsNegativeInfinity(value) && double.IsNegative(value)) return false;
            return true;
        }
    }
}
