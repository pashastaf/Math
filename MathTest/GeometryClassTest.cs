using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MathLibraryClass;

namespace MathTest
{
    [TestClass]
    public class GeometryClassTest
    {
        [TestMethod]
        public void TriangleArea_a4_b5_res10()
        {
            double a = 4;
            double b = 5;
            double expRes = 10;

            double actRes = GeometryClass.TriangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void TriangleArea_a10_b20_res100()
        {
            double a = 10;
            double b = 20;
            double expRes = 100;

            double actRes = GeometryClass.TriangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void TriangleArea_a5point5_b4_res11()
        {
            double a = 5.5;
            double b = 4;
            double expRes = 11;

            double actRes = GeometryClass.TriangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void RightTriangleArea_a3_b4_res6()
        {
            double a = 3;
            double b = 4;
            double expRes = 6;

            double actRes = GeometryClass.RightTriangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void RightTriangleArea_a5_b12_res30()
        {
            double a = 5;
            double b = 12;
            double expRes = 30;

            double actRes = GeometryClass.RightTriangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void RightTriangleArea_a8_b15_res60()
        {
            double a = 8;
            double b = 15;
            double expRes = 60;

            double actRes = GeometryClass.RightTriangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void RectangleArea_a4_b5_res20()
        {
            double a = 4;
            double b = 5;
            double expRes = 20;

            double actRes = GeometryClass.RectangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void RectangleArea_a5_b10_res50()
        {
            double a = 5;
            double b = 10;
            double expRes = 50;

            double actRes = GeometryClass.RectangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void RectangleArea_a2_b2_res4()
        {
            double a = 2;
            double b = 2;
            double expRes = 4;

            double actRes = GeometryClass.RectangleArea(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void CircleArea_a2_res12point57()
        {
            double a = 2;
            double expRes = 12.57;

            double actRes = GeometryClass.CircleArea(a);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void CircleAreaa3_res28point27()
        {
            double a = 3;
            double expRes = 28.27;

            double actRes = GeometryClass.CircleArea(a);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void CircleArea_a4_res50point27()
        {
            double a = 4;
            double expRes = 50.27;

            double actRes = GeometryClass.CircleArea(a);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void TrapezoidArea_a4_b5h10res90()
        {
            double a = 4;
            double b = 5;
            double h = 10;
            double expRes = 45;

            double actRes = GeometryClass.TrapezoidArea(a, b, h);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void TrapezoidArea_a3_b7_h8_res40()
        {
            double a = 3;
            double b = 7;
            double h = 8;
            double expectedRes = 40;

            double actualRes = GeometryClass.TrapezoidArea(a, b, h);

            Assert.AreEqual(expectedRes, actualRes);
        }

        [TestMethod]
        public void TrapezoidAreaa6_b6_h3point5_res21()
        {
            double a = 6;
            double b = 6;
            double h = 3.5;
            double expectedRes = 21;

            double actualRes = GeometryClass.TrapezoidArea(a, b, h);

            Assert.AreEqual(expectedRes, actualRes);
        }

    }
}
