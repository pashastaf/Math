using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryClass
{
    public class TrigonometryClass
    {
        public static double SinValue(double hypotenuse, double oppos, double adj)
        {
            return oppos / hypotenuse;
        }
        public static double CosValue(double hypotenuse, double oppos, double adj)
        {
            return adj / hypotenuse;
        }
        public static double TanValue(double hypotenuse, double oppos, double adj)
        {
            return oppos / adj;
        }
        public static double CotanValue(double hypotenuse, double oppos, double adj)
        {
            return adj / oppos;
        }
        public static double ArcsinValue(double hypotenuse, double oppos, double adj)
        {
            return Math.Asin(SinValue(hypotenuse, oppos, adj));
        }
    }
}
