using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class TstOrderline
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
            int TestData = 1;
            AnOrderL.Quantity = TestData;
            Assert.AreEqual(AnOrderL.Quantity, TestData);

        }
        [TestMethod]
        public void OLineNumberOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 6;
            AnOrderL.OLineNumber = TestData;
            Assert.AreEqual(AnOrderL.OLineNumber, TestData);

        }
        [TestMethod]
        public void ONumberOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 1;
            AnOrderL.ONumber = TestData;
            Assert.AreEqual(AnOrderL.ONumber, TestData);

        }
        [TestMethod]
        public void ShoeIDOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 4;
            AnOrderL.ShoeID = TestData;
            Assert.AreEqual(AnOrderL.ShoeID, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderline AnOrderline = new clsOrderline();
            Boolean Found = false;
            Int32 OLineNumber = 10;
            Found = AnOrderline.Find(OLineNumber);

            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindOLineNumberOK()
        {
            clsOrderline AnOrderline = new clsOrderline();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OLineNumber = 10;
            Found = AnOrderline.Find(OLineNumber);

            if (AnOrderline.OLineNumber != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindONumberOK()
        {
            clsOrderline AnOrderline = new clsOrderline();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ONumber = 8;
            Found = AnOrderline.Find(ONumber);

            if (AnOrderline.ONumber != 8)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindQuantityOK()
        {
            clsOrderline AnOrderline = new clsOrderline();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Quantity = 0;
            Found = AnOrderline.Find(Quantity);

            if (AnOrderline.Quantity != 0)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindShoeIDOK()
        {
            clsOrderline AnOrderline = new clsOrderline();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShoeID = 3;
            Found = AnOrderline.Find(ShoeID);

            if (AnOrderline.ShoeID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
