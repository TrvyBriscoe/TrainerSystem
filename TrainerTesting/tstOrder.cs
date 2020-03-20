using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class TstOrder
    {
        [TestMethod]
        public void OrderExists()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);

        }
        [TestMethod]
        public void ONumberOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.ONumber = TestData;
            Assert.AreEqual(AnOrder.ONumber, TestData);

        }
        [TestMethod]
        public void NotesOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Reception";
            AnOrder.Notes = TestData;
            Assert.AreEqual(AnOrder.Notes, TestData);

        }
        [TestMethod]
        public void CompleteOK()
        {
            clsOrder AnOrder = new clsOrder();
            bool TestData = true;
            AnOrder.Complete = TestData;
            Assert.AreEqual(AnOrder.Complete, TestData);

        }
        [TestMethod]
        public void DateOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.Date = TestData;
            Assert.AreEqual(AnOrder.Date, TestData);

        }

    }
}
