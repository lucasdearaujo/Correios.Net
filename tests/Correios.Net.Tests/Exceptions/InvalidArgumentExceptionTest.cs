using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Correios.Net.Tests.Exceptions
{
    [TestClass]
    public class InvalidArgumentExceptionTest
    {
        [TestMethod]
        public void TestExceptionMessage()
        {
            string message = "Message";

            try
            {
                throw new Correios.Net.Exceptions.InvalidArgumentException(message);
            }
            catch (Correios.Net.Exceptions.InvalidArgumentException ex)
            {
                Assert.AreEqual(message, ex.Message);
            }
        }
    }
}
