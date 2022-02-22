using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstShoeValue
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsShoeValue AShoeValue = new clsShoeValue();
            Assert.IsNotNull(AShoeValue);
        }
    }
}
