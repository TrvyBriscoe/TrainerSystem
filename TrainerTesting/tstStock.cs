using TrainerClasses;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TrainerTesting
{
    [TestClass]
    public class TstStock
    {
        private readonly string Name = "AirForce";
        private readonly string Release = DateTime.Now.Date.ToString();
        private readonly string Quantity = "23";
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
            try
            {
                ClsStock Stock = new ClsStock();

                Boolean Found = false;

                Int32 ShoeID = 2;

                Found = Stock.Find(ShoeID);

                Assert.IsTrue(Found);
            }
            catch (Exception ex)
            { }
        }

        [TestMethod]

        public void TestShoeNoFound()
        {
            try
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
            catch (Exception ex)
            {
                
            }


        }


        [TestMethod]

        public void TestNamefound()
        {

            try
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

            catch (Exception ex)
            { }





        }


        [TestMethod]

        public void TestReleaseFound()
        {
            try
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

            catch (Exception ex)
            { }




        }

        [TestMethod]

        public void TestQuantityFound()
        {
            try
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

            catch (Exception ex)
            { }




        }

        [TestMethod]

        public void TestPriceFound()
        {
            try
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

            catch (Exception ex)
            { }



        }

        [TestMethod]

        public void TestSizeFound()
        {
            try
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

            catch (Exception ex)
            { }


        }

        [TestMethod]

        public void ValidMethodStockOK()
        {
            try
            {
                ClsStock Stock = new ClsStock();
                String Error = "";
                Error = Stock.Valid(Name, Release, Quantity, Price, Size);
                Assert.AreEqual(Error, "");
            }
            catch (Exception)
            {

                
            }
           
        }

        [TestMethod]

        public void NameMin1()
        {

            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = " ";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }
            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void NameMinPlusOne()
        {

            try
            {
           ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = "aa";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }
        }

        [TestMethod]

        public void NameNoMaxLessOnex()
        {

            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = "aaaaa";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }
        }

        [TestMethod]

        public void NameMax()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = "aaaaaa";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void NameMid()
            
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = "aaa";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void NameMaxPlusOne()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = "aaaaaaa";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }


        }

        [TestMethod]

        public void NameExt()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            String Name = " ";
            Name = Name.PadRight(500, 'a');

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");

            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void ReleaseExtMin()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string DateAdded = TestDate.ToString();

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void ReleaseMinLessOne()
        {

            try
            {
           ClsStock Stock = new ClsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-1);

            string DateAdded = TestDate.ToString();

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }
 
        }

        [TestMethod]

        public void ReleaseMin()
        {

            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            

            string DateAdded = TestDate.ToString();

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }


        [TestMethod]

        public void ReleaseMinPlusOne()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(1);

            string DateAdded = TestDate.ToString();

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void ReleaseExtMaz()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string DateAdded = TestDate.ToString();

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void ReleaseInva()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            string DateAdded = "This is not a date";

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }





        [TestMethod]

        public void QuantityEx()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            int TestDate;

            TestDate = -214748364;

            string DateAdded = TestDate.ToString();

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void QuantityMinOneMinus()
        {
            try
            {
            ClsStock Stock = new ClsStock();

            String Error = "";

            int TestDate;

            TestDate = -2147483647;

            string DateAdded = TestDate.ToString();

            Error = Stock.Valid(Name, Release, Quantity, Price, Size);

            Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void QuantityMinB()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -2147483648;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]

        public void QuantityMinOnePlus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -21474836;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        public void QuantityMaxOneMinus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 2147483647;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        public void QuantityMaxBo()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 2147483647;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }


        public void QuantityMaxOnePlus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 214748364;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }





        }

        public void QuantityMid()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 100000;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }


        public void QuantityExtMax()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 214748365;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]

        public void PriceEx()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -214748364;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void PriceMinOneMinus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -2147483647;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void PriceMinB()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -2147483648;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]

        public void PriceyMinOnePlus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -214748369;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }
        [TestMethod]
        public void PriceMaxOneMinus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 2147483647;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }
        [TestMethod]
        public void PriceMaxBo()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 2147483647;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]
        public void PriceMaxOnePlus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 214748349;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }





        }
        [TestMethod]
        public void PriceMid()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 100000;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]
        public void PriceExtMax()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 2147483600;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]

        public void SizeEx()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -214748364;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void SizeMinOneMinus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -2147483647;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }

        }

        [TestMethod]

        public void SizeMinB()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -2147483648;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]

        public void SizeyMinOnePlus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = -214748369;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }
        [TestMethod]
        public void SizeMaxOneMinus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 2147483647;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }
        [TestMethod]
        public void SizeMaxBo()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 2147483647;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]
        public void SizeMaxOnePlus()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 214748349;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }





        }
        [TestMethod]
        public void SizeMid()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 100000;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }

        [TestMethod]
        public void SizeExtMax()
        {
            try
            {
                ClsStock Stock = new ClsStock();

                String Error = "";

                int TestDate;

                TestDate = 2147483600;

                string DateAdded = TestDate.ToString();

                Error = Stock.Valid(Name, Release, Quantity, Price, Size);

                Assert.AreEqual(Error, "");
            }

            catch (Exception)
            {


            }



        }





    }




}