using TrainerClasses;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TrainerTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStock Stock = new clsStock();

            Assert.IsNotNull(Stock);
        }

    [TestMethod]

    public void ShoeIdOK()
        {
            clsStock Stock = new clsStock();

            int TestData = 1;

            Stock.Shoeid = TestData;

            Assert.AreEqual(Stock.Shoeid, TestData);

        }


        [TestMethod]

        public void NameOK1()
        {
            clsStock Stock = new clsStock();

            var TestData = "Nike";

            Stock.Name = TestData;

            Assert.AreEqual(Stock.Name, TestData);

        }

        [TestMethod]

        public void ReleaseOK()
        {
            clsStock Stock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            Stock.Release = TestData;

            Assert.AreEqual(Stock.Release, TestData);

        }

        [TestMethod]

        public void QuantityStockOK()
        {
            clsStock Stock = new clsStock();

            int TestData = 4;

            Stock.QuantityStock = TestData;

            Assert.AreEqual(Stock.QuantityStock, TestData);

        }

        [TestMethod]

        public void PriceStockOK()
        {
            clsStock Stock = new clsStock();

            int TestData = 4;

            Stock.PriceStock = TestData;

            Assert.AreEqual(Stock.PriceStock, TestData);

        }

        [TestMethod]

        public void SizekOK()
        {
            clsStock Stock = new clsStock();

            int TestData = 10;

            Stock.Size = TestData;

            Assert.AreEqual(Stock.Size, TestData);

        }
    }

    


}





