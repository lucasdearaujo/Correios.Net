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
            Address address = Correios.Net.BuscaCep.GetAddress("87710-130");
            
        }
    }
}
