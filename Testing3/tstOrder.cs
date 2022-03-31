using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to creat
            clsOrder AnOrder = new clsOrder();
            //test to see that it exsits
            Assert.IsNotNull(AnOrder);
        }
    }
}
