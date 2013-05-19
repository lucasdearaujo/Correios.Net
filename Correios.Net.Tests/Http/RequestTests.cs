using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Correios.Net.Http;
using Correios.Net.Models;
using Correios.Net.Http.RequestProfiles;

namespace Correios.Net.Tests.Http
{
    [TestClass]
    public class RequestTests
    {
        [TestMethod]
        public void TestGetResult()
        {
            var request = new Request<BuscaEndereco>(new Endereco { Cep = "87710-130" });
            request.Send();
        }
    }
}
