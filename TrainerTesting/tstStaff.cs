using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
            //checks to see if an instance can be created of clsStaff
        {
            //create an object based on clsStaff
            clsStaff AnStaff = new clsStaff();
            //check that the object is not null
            Assert.IsNotNull(AnStaff);
        }
    }
}
