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
            int TestData = 1;
            AnOrderL.Active = TestData;
            Assert.AreEqual(AnOrderL.Active, TestData);

        }
        [TestMethod]
        public void OLineNumberOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 6;
            AnOrderL.Active = TestData;
            Assert.AreEqual(AnOrderL.Active, TestData);

        }
        [TestMethod]
        public void ONumberOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 1;
            AnOrderL.Active = TestData;
            Assert.AreEqual(AnOrderL.Active, TestData);

        }
        [TestMethod]
        public void ShoeIDOK()
        {
            clsOrderline AnOrderL = new clsOrderline();
            int TestData = 4;
            AnOrderL.Active = TestData;
            Assert.AreEqual(AnOrderL.Active, TestData);

        }
        [TestMethod]
        public void FindOLineNumberOK()
        {
            clsOrderline AnOrderline = new clsOrderline();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OLineNumber = 6;
            Found = AnOrderline.Find(OLineNumber);
            
            if (AnOrderline.OLineNumber !=6)
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
            Int32 ONumber = 1;
            Found = AnOrderline.Find(ONumber);

            if (AnOrderline.ONumber != 1)
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
            Int32 Quantity = 1;
            Found = AnOrderline.Find(Quantity);

            if (AnOrderline.Quantity != 1)
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
            Int32 ShoeID = 4;
            Found = AnOrderline.Find(ShoeID);

            if (AnOrderline.ShoeID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
