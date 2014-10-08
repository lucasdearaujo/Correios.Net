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
        public void TestEndereçoComComplemento()
        {
            Address address = SearchZip.GetAddress("30112010");

            Assert.AreEqual(address.Zip, "30112010");
            Assert.AreEqual(address.Street, "Rua Antônio de Albuquerque");
            Assert.AreEqual(address.District, "Funcionários");
            Assert.AreEqual(address.City, "Belo Horizonte");
            Assert.AreEqual(address.State, "MG");
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

        [TestMethod]
        public void TestCepInvalido()
        {
            Address address = SearchZip.GetAddress("00000010");

            Assert.IsNull(address.Zip);
            Assert.AreEqual(address.Street, "Não encontrado");
            Assert.IsNull(address.District);
            Assert.AreEqual(address.City, "Não encontrado");
            Assert.IsNull(address.State);
            Assert.AreEqual(address.UniqueZip, false);
        }
    }
}
