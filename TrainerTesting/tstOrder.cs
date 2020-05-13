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
            ClsOrder AnOrder = new ClsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            int TestData = 1;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);

        }
        [TestMethod]
        public void ONumberOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            int TestData = 1;
            AnOrder.ONumber = TestData;
            Assert.AreEqual(AnOrder.ONumber, TestData);

        }
        [TestMethod]
        public void NotesOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            string TestData = "Reception";
            AnOrder.Notes = TestData;
            Assert.AreEqual(AnOrder.Notes, TestData);

        }
        [TestMethod]
        public void CompleteOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            bool TestData = true;
            AnOrder.Complete = TestData;
            Assert.AreEqual(AnOrder.Complete, TestData);

        }
        [TestMethod]
        public void DateOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.Date = TestData;
            Assert.AreEqual(AnOrder.Date, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Int32 ONumber = 3;
            Found = AnOrder.Find(ONumber);

            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindONumberOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ONumber = 1;
            Found = AnOrder.Find(ONumber);

            if (AnOrder.ONumber != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindCustomerIDOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ONumber = 1;
            Found = AnOrder.Find(ONumber);

            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindNotesOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ONumber = 1;
            Found = AnOrder.Find(ONumber);

            if (AnOrder.Notes != "Leave with reception")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindCompleteOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ONumber = 1;
            Found = AnOrder.Find(ONumber);

            if (AnOrder.Complete != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindDateOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ONumber = 1;
            Found = AnOrder.Find(ONumber);

            if (AnOrder.Date != Convert.ToDateTime("11/01/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
