using TrainerClasses;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TrainerTesting
{
    
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStock Stock = new clsStock();

            Assert.IsNotNull(Stock);
        }
    }
}



