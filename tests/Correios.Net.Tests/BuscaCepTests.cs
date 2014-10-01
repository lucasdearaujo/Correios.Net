using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Correios.Net;

namespace Correios.Net.Tests
{
    [TestClass]
    public class BuscaCepTests
    {
        [TestMethod]
        public void TestAquisiçãoDoEndereço()
        {
            Address address = SearchZip.GetAddress("87710130");

            Assert.AreEqual(address.Zip, "87710130");
            Assert.AreEqual(address.Street, "Avenida Euclides da Cunha");
            Assert.AreEqual(address.District, "Jardim São Jorge");
            Assert.AreEqual(address.City, "Paranavaí");
            Assert.AreEqual(address.State, "PR");
            Assert.AreEqual(address.UniqueZip, false);
        }

        [TestMethod]
        public void TestAquisiçãoDoEndereçoUnico()
        {
            Address address = SearchZip.GetAddress("17180000");

            Assert.AreEqual(address.Zip, "17180000");
            Assert.AreEqual(address.Street, String.Empty);
            Assert.AreEqual(address.District, String.Empty);
            Assert.AreEqual(address.City, "Iacanga");
            Assert.AreEqual(address.State, "SP");
            Assert.AreEqual(address.UniqueZip, true);
        }
    }
}
