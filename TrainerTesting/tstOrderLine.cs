using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{


    [TestClass]
    public class TstOrderline
    {
        string ONumber = "1";
        string Quantity = "0";
        string ShoeID = "3";
        
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
            Int32 OLineNumber = 8;
            Found = AnOrderline.Find(OLineNumber);

            if (AnOrderline.OLineNumber != 8)
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
            Int32 OLineNumber = 8;
            Found = AnOrderline.Find(OLineNumber);

            if (AnOrderline.Quantity != 4)
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
            Int32 OLineNumber = 8;
            Found = AnOrderline.Find(OLineNumber);

            if (AnOrderline.ONumber != 3)
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
            Int32 OLineNumber = 8;
            Found = AnOrderline.Find(OLineNumber);

            if (AnOrderline.ShoeID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderline AnOrderline = new clsOrderline();
            String Error = "";
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ONumberMin()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String ONumber = "1"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ONumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String ONumber = "2"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ONumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String ONumber = "999"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ONumberMax()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String ONumber = "1000"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ONumberMid()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String ONumber = "500"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ONumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String ONumber = "1001"; //this should fail
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ONumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String ONumber = "2000"; //this should fail
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ONumberInvalidDataType()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String ONumber = "This is not a number"; //this should fail
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Quantity = "0"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Quantity = "1"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Quantity = "4"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Quantity = "5"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Quantity = "3"; //this should be ok
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Quantity = "6"; //this should fail
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Quantity = "100"; //this should fail
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityInvalidDataType()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Quantity = "This is not a number"; //this should fail
            //invoke the method
            Error = AnOrderline.Valid(ONumber, Quantity, ShoeID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
