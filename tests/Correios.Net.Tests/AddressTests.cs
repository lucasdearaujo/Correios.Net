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
        Address Address = new Address();

        [TestMethod]
        [ExpectedException(typeof(InvalidArgumentException))]
        public void TestSettingInvalidCep()
        {

            this.Address.Cep = "8771013099";
            this.Address.Cep = "87710--130";
        }

        [TestMethod]
        public void TestSettingValidCep()
        {
            string cep = "87710-130";
            this.Address.Cep = cep;

            Assert.AreEqual(this.Address.Cep, cep);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidArgumentException))]
        public void TestSettingInvalidStreet()
        {
            string street = "Lorem Ipsum ist ein einfacher Demo-Text für die Print- und Schriftindustrie." +
                             "Lorem Ipsum ist in der Industrie bereits der Standard Demo-Text seit 1500, " +
                             "als ein unbekannter Schriftsteller eine Hand voll Wörter nahm und diese durcheinander" +
                             "warf um ein Musterbuch zu erstellen. Es hat nicht nur 5 Jahrhunderte überlebt, sondern" +
                             "auch in Spruch in die elektronische Schriftbearbeitung geschafft (bemerke, nahezu unverändert)." +
                             "Bekannt wurde es 1960, mit dem erscheinen von \"Letraset\", welches Passagen von Lorem Ipsum" +
                             "enhielt, so wie Desktop Software wie \"Aldus PageMaker\" - ebenfalls mit Lorem Ipsum.";

            this.Address.Street = street;
        }

        [TestMethod]
        public void TestSettingValidStreet()
        {
            string expected = "Avenida Euclides da Cunha";
            this.Address.Street = expected;

            Assert.AreEqual(this.Address.Street, expected);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidArgumentException))]
        public void TestSettingInvalidCity()
        {
            string city    = "Lorem Ipsum ist ein einfacher Demo-Text für die Print- und Schriftindustrie." +
                             "Lorem Ipsum ist in der Industrie bereits der Standard Demo-Text seit 1500, " +
                             "als ein unbekannter Schriftsteller eine Hand voll Wörter nahm und diese durcheinander" +
                             "warf um ein Musterbuch zu erstellen. Es hat nicht nur 5 Jahrhunderte überlebt, sondern" +
                             "auch in Spruch in die elektronische Schriftbearbeitung geschafft (bemerke, nahezu unverändert)." +
                             "Bekannt wurde es 1960, mit dem erscheinen von \"Letraset\", welches Passagen von Lorem Ipsum" +
                             "enhielt, so wie Desktop Software wie \"Aldus PageMaker\" - ebenfalls mit Lorem Ipsum.";

            this.Address.City = city;
        }
    }
}
