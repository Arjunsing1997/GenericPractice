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
            int actual = p.MaxIntNumber(10, 15, 14);

            int Exp = 15;

            Assert.AreEqual(actual, Exp);

        }

        [TestMethod]
        public void MaxDoubleNumber()
        {
            Program p = new Program();
            double actual = p.MaxDoubleNumber(10.6, 10.0, 14.6);

            double Exp = 14.6;

            Assert.AreEqual(actual, Exp);

        }

        [TestMethod]
        public void MaxStringNumber()
        {
            Program p = new Program();
            string actual = p.MaxChar("abc","cde","xyz");

            string Exp = "xyz";

            Assert.AreEqual(actual, Exp);

        }
    }

}
