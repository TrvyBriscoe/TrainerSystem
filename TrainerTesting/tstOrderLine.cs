using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class tstOrderline
    {
        [TestMethod]
        public void OrderLineExists()
        {
            clsOrderline AnOrderL = new clsOrderline();
            Assert.IsNotNull(AnOrderL);
        }

        [TestMethod]
        public void QuantityOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 3;
            AnOrderL.Active = TestData;
            Assert.AreEqual(AnOrderL.Active, TestData);

        }
        [TestMethod]
        public void OLineNumberOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 1;
            AnOrderL.Active = TestData;
            Assert.AreEqual(AnOrderL.Active, TestData);

        }
        [TestMethod]
        public void ONumberOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 5;
            AnOrderL.Active = TestData;
            Assert.AreEqual(AnOrderL.Active, TestData);

        }
        [TestMethod]
        public void ShoeIDOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 2;
            AnOrderL.Active = TestData;
            Assert.AreEqual(AnOrderL.Active, TestData);

        }
    }
}
