using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void Postitive()
        {
            var R = new Rectanle();

            R.Rectangle(2,2);
        }
    }
}
