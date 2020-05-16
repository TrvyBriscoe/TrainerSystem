using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<ClsOrder> TestList = new List<ClsOrder>();
            ClsOrder TestItem = new ClsOrder();

            
            TestItem.ONumber = 1;
            TestItem.CustomerID = 1;
            TestItem.Notes = "";
            TestItem.Complete = true;
            TestItem.Date = DateTime.Now.Date;
            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderProperyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            ClsOrder TestItem = new ClsOrder();
            TestItem.ONumber = 1;
            TestItem.CustomerID = 1;
            TestItem.Notes = "";
            TestItem.Complete = true;
            TestItem.Date = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<ClsOrder> TestList = new List<ClsOrder>();
            ClsOrder TestItem = new ClsOrder();
            TestItem.ONumber = 1;
            TestItem.CustomerID = 1;
            TestItem.Notes = "";
            TestItem.Complete = true;
            TestItem.Date = DateTime.Now.Date;
            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            ClsOrder TestItem = new ClsOrder();
            Int32 PKey = 0;
            TestItem.ONumber = 1;
            TestItem.CustomerID = 1;
            TestItem.Notes = "work";
            TestItem.Complete = true;
            TestItem.Date = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PKey = AllOrders.Add();
            TestItem.ONumber = PKey;
            AllOrders.ThisOrder.Find(PKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            ClsOrder TestItem = new ClsOrder();
            Int32 PKey = 0;
            TestItem.ONumber = 21;
            TestItem.CustomerID = 1;
            TestItem.Notes = "";
            TestItem.Complete = true;
            TestItem.Date = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PKey = AllOrders.Add();
            TestItem.ONumber = PKey;
            AllOrders.ThisOrder.Find(PKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            ClsOrder TestItem = new ClsOrder();
            Int32 PKey = 1;
            TestItem.ONumber = 3;
            TestItem.CustomerID = 4;
            TestItem.Notes = "";
            TestItem.Complete = true;
            TestItem.Date = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PKey = AllOrders.Add();
            TestItem.ONumber = 7;
            TestItem.CustomerID = 3;
            TestItem.Notes = "agile";
            TestItem.Complete = false;
            TestItem.Date = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
    }
}

