using MathLibraryClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MathTest
{
    [TestClass]
    public class AlgebraClassTest
    {
        [TestMethod]
        public void IncompleteQuadraticeQuationsa1b0c4res2minus2()
        {
            double a = 1;
            double b = 0;
            double c = -4;
            List<double> expectedRoots = new List<double> { 2, -2 };

            List<double> actualRoots = AlgebraClass.SolveSquareRootEquation(a, b, c);

            CollectionAssert.AreEqual(expectedRoots, actualRoots);
        }

        [TestMethod]
        public void IncompleteQuadraticeQuationsa1b4c0res0and4()
        {
            double a = 1;
            double b = -4;
            double c = 0;
            List<double> expectedRoots = new List<double> { 0, 4 };

            List<double> actualRoots = AlgebraClass.SolveSquareRootEquation(a, b, c);

            CollectionAssert.AreEqual(expectedRoots, actualRoots);
        }

        [TestMethod]
        public void CompleteQuadraticeQuationsa1bminus2cminus3resminus1and3()
        {
            double a = 1;
            double b = -2;
            double c = -3;
            List<double> expectedRoots = new List<double> { -1, 3 };

            List<double> actualRoots = AlgebraClass.SolveSquareRootEquation(a, b, c);

            CollectionAssert.AreEqual(expectedRoots, actualRoots);
        }

        [TestMethod]
        public void LinearEquationa1b2resminus2()
        {
            double a = 1;
            double b = 2;
            double expRes = -2;

            double actRes = AlgebraClass.SolveLinearEquation(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void LinearEquationa5b2resminus0point4()
        {
            double a = 5;
            double b = 2;
            double expRes = -0.4;

            double actRes = AlgebraClass.SolveLinearEquation(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void LinearEquationa8b4resminus0point5()
        {
            double a = 8;
            double b = 4;
            double expRes = -0.5;

            double actRes = AlgebraClass.SolveLinearEquation(a, b);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void SumSeriesList1and2and3and4and5res15()
        {
            List<double> list = new List<double>() { 1, 2, 3, 4, 5 };
            double expRes = 15;

            double actRes = AlgebraClass.SumSeries(list);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void SumSeriesList1and2and3andminus1andminus2andminus3res0()
        {
            List<double> list = new List<double>() { 1, 2, 3, -1, -2, -3 };
            double expRes = 0;

            double actRes = AlgebraClass.SumSeries(list);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void SumSeriesList100and200and300andminus500res100()
        {
            List<double> list = new List<double>() { 100, 200, 300, -500};
            double expRes = 100;

            double actRes = AlgebraClass.SumSeries(list);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void MaxSeriesList1and2and3and4and5res5()
        {
            List<double> list = new List<double>() { 1, 2, 3, 4, 5 };
            double expRes = 5;

            double actRes = AlgebraClass.MaxSeries(list);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void MaxSeriesList1and2and3andminus1andminus2andminus3res3()
        {
            List<double> list = new List<double>() { 1, 2, 3, -1, -2, -3 };
            double expRes = 3;

            double actRes = AlgebraClass.MaxSeries(list);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void MaxSeriesList100and200and300andminus500res300()
        {
            List<double> list = new List<double>() { 100, 200, 300, -500 };
            double expRes = 300;

            double actRes = AlgebraClass.MaxSeries(list);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void AvgSeriesList1and2and3and4and5res3()
        {
            List<double> list = new List<double>() { 1, 2, 3, 4, 5 };
            double expRes = 3;

            double actRes = AlgebraClass.AvgSeries(list);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void AvgSeriesList1and2and0andminus1andminus2and3and4res1()
        {
            List<double> list = new List<double>() { 1, 2, 0, -1, -2, 3, 4 };
            double expRes = 1;

            double actRes = AlgebraClass.AvgSeries(list);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void AvgSeriesList100and200and300andminus500res25()
        {
            List<double> list = new List<double>() { 100, 200, 300, -500 };
            double expRes = 25;

            double actRes = AlgebraClass.AvgSeries(list);

            Assert.AreEqual(expRes, actRes);
        }


    }
}
