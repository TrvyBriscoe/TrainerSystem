using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }
    }
}
