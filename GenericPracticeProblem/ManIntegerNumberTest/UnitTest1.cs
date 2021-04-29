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
            int actual = p.MaxIntNumber(10, 9, 4);

            int Exp = 10;

            Assert.AreEqual(actual, Exp);

        }
    }
}
