using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstShoeValue
    {
        [TestMethod]
        public void InststanceOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //test to see that it exists
            Assert.IsNotNull(AnShoeValue);


        }
    }
}
