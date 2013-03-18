using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Correios.Net;
using Correios.Net.Exceptions;

namespace Correios.Net.Tests
{
    /// <summary>
    /// Summary description for AddressTests
    /// </summary>
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidArgumentException))]
        public void TestInvalidCep()
        {
            Address Address = new Address();
            Address.Cep = "8771013099";

            Address Address2 = new Address();
            Address2.Cep = "87710--130";
        }

        [TestMethod]
        public void TestSettingValues()
        {
            string cep = "87710-130";

            Address address = new Address();
            address.Cep = cep;

            Assert.AreEqual(address.Cep, cep);
        }
    }
}
