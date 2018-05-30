using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.Library;

namespace SampleLibrary.Tests2
{

    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestMe()
        {
            var x = new Button1();
            Assert.IsNotNull(x);
        }
    }
}
