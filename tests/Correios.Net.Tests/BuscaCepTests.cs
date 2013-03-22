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
            Address address = Correios.Net.BuscaCep.GetAddress("87710130");

            Assert.AreEqual(address.Cep, "87710130");
            Assert.AreEqual(address.Street, "Avenida Euclides da Cunha");
            Assert.AreEqual(address.District, "Jardim São Jorge");
            Assert.AreEqual(address.City, "Paranavaí");
            Assert.AreEqual(address.State, "PR");
            Assert.AreEqual(address.CepUnico, false);
        }

        [TestMethod]
        public void TestAquisiçãoDoEndereçoUnico()
        {
            Address address = Correios.Net.BuscaCep.GetAddress("17180000");

            Assert.AreEqual(address.Cep, "17180000");
            Assert.AreEqual(address.Street, String.Empty);
            Assert.AreEqual(address.District, String.Empty);
            Assert.AreEqual(address.City, "Iacanga");
            Assert.AreEqual(address.State, "SP");
            Assert.AreEqual(address.CepUnico, true);
        }
    }
}
