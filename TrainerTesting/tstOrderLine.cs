using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainerClasses;

namespace TrainerTesting
{
    public class tstOrderline
    {
       [TestMethod]
            public void OrderLineExists()
            {
                clsOrderline AnOrderL = new clsOrderline();
                Assert.IsNotNull(AnOrderL);
            }
        }
    }


