using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Correios.Net.Http;

namespace Correios.Net.Tests.Http
{
    [TestClass]
    public class RequestTests
    {
        Request Request;

        [TestMethod]
        public void TestConstructorParameters()
        {
            string url = "http://www.gooogle.com/";
            string dataToSend = "hello=oi";
            string method = "POST";

            this.Request = new Correios.Net.Http.Request(url, dataToSend, method, String.Empty);

            Assert.AreEqual(Request.Url, url);
            Assert.AreEqual(Request.DataToSend, dataToSend);
            Assert.AreEqual(Request.Method, method);
        }

        [TestMethod]
        public void TestDataReceived()
        {
            string url = "http://pastebin.com/raw.php?i=fdHMhAaj";
            string dataToSend = String.Empty;
            string method = "POST";

            this.Request = new Correios.Net.Http.Request(url, dataToSend, method, String.Empty);
            Response response = this.Request.Send(10000);

            Assert.AreEqual(response.Text, "teste");
        }
    }
}
