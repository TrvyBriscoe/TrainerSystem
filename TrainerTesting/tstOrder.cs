using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class TstOrder
    {
        string CustomerID = "1";
        string Notes = "notes";
        string Date = DateTime.Now.Date.ToString();
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
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerID = "1"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerID = "2"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerID = "999"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerID = "1000"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerID = "500"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerID = "1001"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerID = "2000"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NotesMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Notes = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NotesMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Notes = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NotesMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Notes = "";
            Notes = Notes.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Notes = "";
            Notes = Notes.PadRight(50, 'a');//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NotesMid()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Notes = "";
            Notes = Notes.PadRight(25, 'a');//this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Notes = "";
            Notes = Notes.PadRight(51, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NotesExtremeMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Notes = "";
            Notes = Notes.PadRight(100, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            String Dated = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, Notes, Dated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
