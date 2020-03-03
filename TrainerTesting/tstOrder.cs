using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void OrderLineExists()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

                [TestMethod]
        public void CustomerIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);

        }
        [TestMethod]
        public void ONumberOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);

        }
       
    }
}
