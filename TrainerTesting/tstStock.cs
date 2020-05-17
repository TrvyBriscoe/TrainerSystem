using TrainerClasses;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TrainerTesting
{
    [TestClass]
    public class TstStock
    {
        private readonly string Name = "Airfoce";
        private readonly string Release = DateTime.Now.Date.ToString();
        private readonly string Quantity = "3";
        private readonly string Price = "70.00";
        private readonly string Size = "5";

        [TestMethod]
        public void TestMethod1()
        {
            ClsStock Stock = new ClsStock();

            Assert.IsNotNull(Stock);
        }

    [TestMethod]

    public void ShoeIdOK()
        {
            ClsStock Stock = new ClsStock();

            int TestData = 1;

            Stock.ShoeID = TestData;

            Assert.AreEqual(Stock.ShoeID, TestData);

        }


        [TestMethod]

        public void NameOK1()
        {
            ClsStock Stock = new ClsStock();

            var TestData = "Nike";

            Stock.Name = TestData;

            Assert.AreEqual(Stock.Name, TestData);

        }

        [TestMethod]

        public void ReleaseOK()
        {
            ClsStock Stock = new ClsStock();

            DateTime TestData = DateTime.Now.Date;

            Stock.Release = TestData;

            Assert.AreEqual(Stock.Release, TestData);

        }

        [TestMethod]

        public void QuantityStockOK()
        {
            ClsStock Stock = new ClsStock();

            int TestData = 4;

            Stock.QuantityStock = TestData;

            Assert.AreEqual(Stock.QuantityStock, TestData);

        }

        [TestMethod]

        public void PriceStockOK()
        {
            ClsStock Stock = new ClsStock();

            int TestData = 4;

            Stock.PriceStock = TestData;

            Assert.AreEqual(Stock.PriceStock, TestData);

        }

        [TestMethod]

        public void SizekOK()
        {
            ClsStock Stock = new ClsStock();

            int TestData = 10;

            Stock.Size = TestData;

            Assert.AreEqual(Stock.Size, TestData);

        }

        [TestMethod]

        public void FindMethodStockOK()
        {
            ClsStock Stock = new ClsStock();

            Boolean Found = false;

            Int32 ShoeID = 2;

            Found = Stock.Find(ShoeID);

            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestShoeNoFound()
        {
            ClsStock Stock = new ClsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ShoeID = 2;

            Found = Stock.Find(ShoeID);

            if (Stock.ShoeID != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);



        }


        [TestMethod]

        public void TestNamefound()
        {
            ClsStock Stock = new ClsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ShoeID = 2;

            Found = Stock.Find(ShoeID); 

            if (Stock.Name != "AirForce")
            {
                OK = false;
            }

            Assert.IsTrue(OK);



        }


        [TestMethod]

        public void TestReleaseFound()
        {
            ClsStock Stock = new ClsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ShoeID = 2;

            Found = Stock.Find(ShoeID);

            if (Stock.Release != Convert.ToDateTime("22/02/2020"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);



        }

        [TestMethod]

        public void TestQuantityFound()
        {
            ClsStock Stock = new ClsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ShoeID = 2;

            Found = Stock.Find(ShoeID);

            if (Stock.QuantityStock != 23)
            {
                OK = false;
            }

            Assert.IsTrue(OK);



        }

        [TestMethod]

        public void TestPriceFound()
        {
            ClsStock Stock = new ClsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ShoeID = 2;

            Found = Stock.Find(ShoeID);

            if (Stock.PriceStock != 70)
            {
                OK = false;
            }

            Assert.IsTrue(OK);



        }

        [TestMethod]

        public void TestSizeFound()
        {
            ClsStock Stock = new ClsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ShoeID = 2;

            Found = Stock.Find(ShoeID);

            if (Stock.Size != 5)
            {
                OK = false;
            }

            Assert.IsTrue(OK);



        }

        [TestMethod]

        public void ValidMethodStockOK()
        {
            ClsStock Stock = new ClsStock();
            String Error = "";
            Error = Stock.Valid(Name, Release, Quantity, Price, Size);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameEMin()
        {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = "-adasdadfda";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameInv()
        {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = ";',24+3";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameEMax()
        {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = "-adasdadfda";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");

        }

    }




}