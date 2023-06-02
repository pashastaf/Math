using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryClass
{
    public class GeometryClass
    {
        public static double TriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double RightTriangleArea(double opposCathet, double adjCathet)
        {
            return 0.5 * opposCathet * adjCathet;
        }

        public static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double CircleArea(double radius)
        {
            return Math.Round(Math.PI * radius * radius,2);
        }

        public static double TrapezoidArea(double base1, double base2, double height)
        {
            return 0.5 * (base1 + base2) * height;
        }
    }
}

