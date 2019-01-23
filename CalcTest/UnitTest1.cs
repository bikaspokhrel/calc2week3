using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calc2week3;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        //we need to instantiate a Form, we create a new form f and pass all the details fo the real form over to it. So f holds the form methods.
        Form1 f = new Form1();
        [TestMethod]
        public void Multiply()
        {
            //then we can get the Multiply method IF it is set to Public back on the form, otherwise you won't see it, if its set to Private.
Single answer = f.Multiply(2, 2);
Assert.AreEqual(4,answer);
        }
    }
}
