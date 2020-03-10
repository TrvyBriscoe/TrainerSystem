using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
            //checks to see if an instance can be created of clsCustomer
        {
            //create an object based on clsCustomer
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);

        }
    }
}
