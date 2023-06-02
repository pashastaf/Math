using MathLibraryClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathTest
{
    [TestClass]
    public class TrigonometryClassTest
    {
        [TestMethod]
        public void SinValue_hypotenuse5_opposite3_adjacent4_res0dot6()
        {
            double hypotenuse = 5;
            double opposite = 3;
            double adjacent = 4;
            double expRes = 0.6;

            double actRes = TrigonometryClass.SinValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void SinValue_hypotenuse10_opposite6_adjacent8_res0dot6()
        {
            double hypotenuse = 10;
            double opposite = 6;
            double adjacent = 8;
            double expRes = 0.6;

            double actRes = TrigonometryClass.SinValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void SinValue_hypotenuse7_opposite2_adjacent5_res0dot2857()
        {
            double hypotenuse = 7;
            double opposite = 2;
            double adjacent = 5;
            double expRes = 0.2857;

            double actRes = TrigonometryClass.SinValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }

        [TestMethod]
        public void CosValue_hypotenuse5_opposite3_adjacent4_res0dot8()
        {
            double hypotenuse = 5;
            double opposite = 3;
            double adjacent = 4;
            double expRes = 0.8;

            double actRes = TrigonometryClass.CosValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void CosValue_hypotenuse10_opposite6_adjacent8_res0dot8()
        {
            double hypotenuse = 10;
            double opposite = 6;
            double adjacent = 8;
            double expRes = 0.8;

            double actRes = TrigonometryClass.CosValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void CosValue_hypotenuse7_opposite2_adjacent5_res0dot7143()
        {
            double hypotenuse = 7;
            double opposite = 2;
            double adjacent = 5;
            double expRes = 0.7143;

            double actRes = TrigonometryClass.CosValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }

        [TestMethod]
        public void TanValue_hypotenuse5_opposite3_adjacent4_res0dot75()
        {
            double hypotenuse = 5;
            double opposite = 3;
            double adjacent = 4;
            double expRes = 0.75;

            double actRes = TrigonometryClass.TanValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void TanValue_hypotenuse10_opposite6_adjacent8_res0dot75()
        {
            double hypotenuse = 10;
            double opposite = 6;
            double adjacent = 8;
            double expRes = 0.75;

            double actRes = TrigonometryClass.TanValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes);
        }

        [TestMethod]
        public void TanValue_hypotenuse7_opposite2_adjacent5_res0dot4()
        {
            double hypotenuse = 7;
            double opposite = 2;
            double adjacent = 5;
            double expRes = 0.4;

            double actRes = TrigonometryClass.TanValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }

        [TestMethod]
        public void CotanValue_hypotenuse5_opposite3_adjacent4_res1dot3333()
        {
            double hypotenuse = 5;
            double opposite = 3;
            double adjacent = 4;
            double expRes = 1.3333;

            double actRes = TrigonometryClass.CotanValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }

        [TestMethod]
        public void CotanValue_hypotenuse10_opposite6_adjacent8_res1dot3333()
        {
            double hypotenuse = 10;
            double opposite = 6;
            double adjacent = 8;
            double expRes = 1.3333;

            double actRes = TrigonometryClass.CotanValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }

        [TestMethod]
        public void CotanValue_hypotenuse7_opposite2_adjacent5_res2dot5()
        {
            double hypotenuse = 7;
            double opposite = 2;
            double adjacent = 5;
            double expRes = 2.5;

            double actRes = TrigonometryClass.CotanValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }

        [TestMethod]
        public void ArcsinValue_hypotenuse5_opposite3_adjacent4_res0dot6435()
        {
            double hypotenuse = 5;
            double opposite = 3;
            double adjacent = 4;
            double expRes = 0.6435;

            double actRes = TrigonometryClass.ArcsinValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }

        [TestMethod]
        public void ArcsinValue_hypotenuse10_opposite6_adjacent8_res0dot6435()
        {
            double hypotenuse = 10;
            double opposite = 6;
            double adjacent = 8;
            double expRes = 0.6435;

            double actRes = TrigonometryClass.ArcsinValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }

        [TestMethod]
        public void ArcsinValue_hypotenuse7_opposite2_adjacent5_res0dot2897()
        {
            double hypotenuse = 7;
            double opposite = 2;
            double adjacent = 5;
            double expRes = 0.2897;

            double actRes = TrigonometryClass.ArcsinValue(hypotenuse, opposite, adjacent);

            Assert.AreEqual(expRes, actRes, 0.0001);
        }
    }
}
