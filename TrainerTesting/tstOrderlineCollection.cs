using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;
using System.Collections.Generic;
namespace TrainerTesting
{
    [TestClass]
    public class tstOrderlineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            Assert.IsNotNull(AllOrderlines);
        }
        [TestMethod]
        public void OrderlineListOK()
        {
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            List<clsOrderline> TestList = new List<clsOrderline>();
            clsOrderline TestItem = new clsOrderline();
            
            TestItem.OLineNumber = 1;
            TestItem.ONumber = 1;
            TestItem.Quantity = 1;
            TestItem.ShoeID = 1;
            TestList.Add(TestItem);

            AllOrderlines.OrderlineList = TestList;
            Assert.AreEqual(AllOrderlines.OrderlineList, TestList);
        }
      
        [TestMethod]
        public void ThisOrderlineProperyOK()
        {
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            clsOrderline TestOrderline = new clsOrderline();
            TestOrderline.OLineNumber = 1;
            TestOrderline.ONumber = 1;
            TestOrderline.Quantity = 1;
            TestOrderline.ShoeID = 1;
            AllOrderlines.ThisOrderline = TestOrderline;
            Assert.AreEqual(AllOrderlines.ThisOrderline, TestOrderline);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            List<clsOrderline> TestList = new List<clsOrderline>();
            clsOrderline TestItem = new clsOrderline();
            TestItem.OLineNumber = 1;
            TestItem.ONumber = 1;
            TestItem.Quantity = 1;
            TestItem.ShoeID = 1;
            TestList.Add(TestItem);

            AllOrderlines.OrderlineList = TestList;
            Assert.AreEqual(AllOrderlines.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            clsOrderline TestItem = new clsOrderline();
            Int32 PKey = 0;
            TestItem.OLineNumber = 1;
            TestItem.ONumber = 1;
            TestItem.Quantity = 1;
            TestItem.ShoeID = 1;
            AllOrderlines.ThisOrderline = TestItem;
            PKey = AllOrderlines.Add();
            TestItem.OLineNumber = PKey;
            AllOrderlines.ThisOrderline.Find(PKey);
            Assert.AreEqual(AllOrderlines.ThisOrderline, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            clsOrderline TestItem = new clsOrderline();
            Int32 PKey = 0;
            TestItem.OLineNumber = 1;
            TestItem.ONumber = 1;
            TestItem.Quantity = 1;
            TestItem.ShoeID = 1;
            AllOrderlines.ThisOrderline = TestItem;
            PKey = AllOrderlines.Add();
            TestItem.OLineNumber = PKey;
            AllOrderlines.ThisOrderline.Find(PKey);
            AllOrderlines.Delete();
            Boolean Found = AllOrderlines.ThisOrderline.Find(PKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            clsOrderline TestItem = new clsOrderline();
            Int32 PKey = 1;
            TestItem.OLineNumber = 1;
            TestItem.ONumber = 1;
            TestItem.Quantity = 1;
            TestItem.ShoeID = 1;
            AllOrderlines.ThisOrderline = TestItem;
            PKey = AllOrderlines.Add();
            TestItem.OLineNumber = PKey;
            TestItem.OLineNumber = 8;
            TestItem.ONumber = 3;
            TestItem.Quantity = 3;
            TestItem.ShoeID = 2;
            AllOrderlines.ThisOrderline = TestItem;
            AllOrderlines.Update();
            AllOrderlines.ThisOrderline.Find(PKey);
            Assert.AreEqual(AllOrderlines.ThisOrderline, TestItem);

        }
        [TestMethod]
        public void FilterByONumber()
        {
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            clsOrderlineCollection FilteredOrderlines = new clsOrderlineCollection();
            FilteredOrderlines.FilterByONum(1);
            Assert.AreEqual(AllOrderlines.Count, FilteredOrderlines.Count);
        }
        [TestMethod]
        public void FilterByONumberTestDataFound()
        {
            clsOrderlineCollection FilteredOLines = new clsOrderlineCollection();
            Boolean OK = true;
            FilteredOLines.FilterByONum(10);
            if (FilteredOLines.Count == 2)
            {
                if (FilteredOLines.OrderlineList[0].OLineNumber != 8)
                {
                    OK = false;
                }
                if (FilteredOLines.OrderlineList[1].OLineNumber != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

