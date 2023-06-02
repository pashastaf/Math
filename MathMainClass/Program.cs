using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibraryClass;

namespace MathMainClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>()
            {
                1, 2, 3, 4, 5, 6, 7
            };
            List<double> result = AlgebraClass.SolveSquareRootEquation(-2, 5, -2);
            string resultString = string.Join("  ", result);
            Console.WriteLine("Корни x1,x2: " + resultString);
            Console.WriteLine("Корень х: " + AlgebraClass.SolveLinearEquation(8, 4));
            Console.WriteLine("Сумма ряда: " + AlgebraClass.SumSeries(list));
            Console.WriteLine("Максимальное число ряда: " + AlgebraClass.MaxSeries(list));
            Console.WriteLine("Среднее число ряда: " + AlgebraClass.AvgSeries(list));

            Console.WriteLine("Площадь треугольника: " + GeometryClass.TriangleArea(5, 2));
            Console.WriteLine("Площадь прямоугольного треугольника: " + GeometryClass.RightTriangleArea(5, 4));
            Console.WriteLine("Площадь прямоугольника: " + GeometryClass.RectangleArea(5, 3));
            Console.WriteLine("Площадь круга: " + GeometryClass.CircleArea(5.3));
            Console.WriteLine("Площадь трапеции: " + GeometryClass.TrapezoidArea(5, 6, 7));

            double h = 5; // Гипотенуза
            double o = 3; // Катет
            double a = 4; // Катет

            Console.WriteLine("Синус: " + TrigonometryClass.SinValue(h, o, a));
            Console.WriteLine("Косинус: " + TrigonometryClass.CosValue(h, o, a));
            Console.WriteLine("Тангенс: " + TrigonometryClass.TanValue(h, o, a));
            Console.WriteLine("Котангенс: " + TrigonometryClass.CotanValue(h, o, a));
            Console.WriteLine("Арксинус: " + TrigonometryClass.ArcsinValue(h, o, a));
            Console.Read();
        }
    }
}

