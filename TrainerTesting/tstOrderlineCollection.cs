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
            TestItem.Active = true;
            TestItem.OLineNumber = 1;
            TestItem.ONumber = 1;
            TestItem.Quantity = 1;
            TestItem.ShoeID = 1;
            TestList.Add(TestItem);

            AllOrderlines.OrderlineList = TestList;
            Assert.AreEqual(AllOrderlines.Count, TestList.Count);
        }
           }
}
