using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;
using System.Collections.Generic;

namespace TrainerTesting
{
    [TestClass]
    public class TstStockCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK1()
        {
            ClsStockCollection AllAddresses = new ClsStockCollection();

            Assert.IsNotNull(AllAddresses);
        }

        [TestMethod]
        public void Stocklist()
        {
            ClsStockCollection AllAddresses = new ClsStockCollection();

            List<ClsStock> TestList = new List<ClsStock>();

            ClsStock TestItem = new ClsStock();

            TestItem.ShoeID = 1;
            TestItem.Name = "AirForce";
            TestItem.Release = DateTime.Now.Date;
            TestItem.QuantityStock = 1;
            TestItem.PriceStock = 1;
            TestItem.Size = 1;

            TestList.Add(TestItem);

            AllAddresses.AddressList = TestList;

            Assert.AreEqual(AllAddresses.AddressList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            ClsStockCollection AllAddresses = new ClsStockCollection();

            Int32 SomeCount1 = 2;

            AllAddresses.Count = SomeCount1;

            Assert.AreEqual(AllAddresses.Count, SomeCount1);


        }

        [TestMethod]
        public void StocklistPropertyOK()
        {
            ClsStockCollection AllAddresses = new ClsStockCollection();

            List<ClsStock> TestList = new List<ClsStock>();

            ClsStock TestItem = new ClsStock();

            TestItem.ShoeID = 1;
            TestItem.Name = "AirForce";
            TestItem.Release = DateTime.Now.Date;
            TestItem.QuantityStock = 1;
            TestItem.PriceStock = 1;
            TestItem.Size = 1;

            TestList.Add(TestItem);

            AllAddresses.ThisStock = TestList;

            Assert.AreEqual(AllAddresses.ThisAddressList, TestList);
        }





        [TestMethod]

        public void AddMethodStockOK()
        {
            ClsStockCollection AllAddresses = new ClsStockCollection();

            ClsStock TestItem = new ClsStock();

            Int32 PrimaryKey = 0;

            TestItem.ShoeID = 1;
            TestItem.Name = "AirForce";
            TestItem.Release = DateTime.Now.Date;
            TestItem.QuantityStock = 1;
            TestItem.PriceStock = 1;
            TestItem.Size = 1;

            AllAddresses.ThisStock = TestItem;

            PrimaryKey = AllAddresses.Add();

            TestItem.ShoeID = PrimaryKey;

            AllAddresses.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllAddresses.ThisAddressList, TestItem);

        }

        [TestMethod]

        public void DeleteMethodStockOK()
        {
            ClsStockCollection AllAddresses = new ClsStockCollection();

            ClsStock TestItem = new ClsStock();

            Int32 PrimaryKey = 0;

            TestItem.ShoeID = 1;
            TestItem.Name = "AirForce";
            TestItem.Release = DateTime.Now.Date;
            TestItem.QuantityStock = 1;
            TestItem.PriceStock = 1;
            TestItem.Size = 1;

            AllAddresses.ThisStock = TestItem;

            PrimaryKey = AllAddresses.Add();

            TestItem.ShoeID = PrimaryKey;

            AllAddresses.ThisStock.Find(PrimaryKey);

            AllAddresses.Delete();

            Assert.AreEqual(AllAddresses.ThisAddressList, TestItem);

        }

        [TestMethod]

        public void UpdateMethodStockOK()
        {
            ClsStockCollection AllAddresses = new ClsStockCollection();

            ClsStock TestItem = new ClsStock();

            Int32 PrimaryKey = 0;

            TestItem.ShoeID = 1;
            TestItem.Name = "AirForce";
            TestItem.Release = DateTime.Now.Date;
            TestItem.QuantityStock = 1;
            TestItem.PriceStock = 1;
            TestItem.Size = 1;

            AllAddresses.ThisStock = TestItem;

            PrimaryKey = AllAddresses.Add();

            TestItem.ShoeID = PrimaryKey;

            TestItem.ShoeID = 4;
            TestItem.Name = "AirForce1";
            TestItem.Release = DateTime.Now.Date;
            TestItem.QuantityStock = 4;
            TestItem.PriceStock = 4;
            TestItem.Size = 4;

            AllAddresses.ThisStock = TestItem;

            AllAddresses.Update();

            AllAddresses.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllAddresses.ThisAddressList, TestItem);

        }





    }
}
