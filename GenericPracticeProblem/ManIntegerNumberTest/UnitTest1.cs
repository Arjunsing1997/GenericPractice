using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericPracticeProblem;

namespace ManIntegerNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void MaxIntegerNumber()
        {
            Program p = new Program();
            double actual = p.MaxIntNumber(10, 15, 14);

            double Exp = 15;

            Assert.AreEqual(actual, Exp);

        }
        public void MaxDoubleNumber()
        {
            Program p = new Program();
            double actual = p.MaxDoubleNumber(10.6, 10.0, 14.6);

            double Exp = 14.6;

            Assert.AreEqual(actual, Exp);

        }
    }

}
