using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Correios.Net;

namespace Correios.Net.Tests.Models
{
    [TestClass]
    public class EnderecoTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exceptions.InvalidEnderecoPropertyException))]
        public void TestSettingAInvalidCEP()
        {
            var endereco = new Correios.Net.Models.Endereco();
            endereco.Cep = "877101-130";
        }

        [TestMethod]
        public void TestSettingAValidCEP()
        {
            var cep = "87710-130";
            var endereco = new Correios.Net.Models.Endereco();
            endereco.Cep = cep;

            Assert.AreEqual(endereco.Cep, cep);
        }

        [TestMethod]
        [ExpectedException(typeof(Exceptions.InvalidEnderecoPropertyException))]
        public void TestSettingAInvalidRua()
        {
            var rua = "lucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucas";
            var endereco = new Correios.Net.Models.Endereco();
            endereco.Rua = rua;
        }

        [TestMethod]
        public void TestSettingAValidRua()
        {
            var rua = "Rua Haiato Nakamura";
            var endereco = new Correios.Net.Models.Endereco();
            endereco.Rua = rua;

            Assert.AreEqual(endereco.Rua, rua);
        }

        [TestMethod]
        [ExpectedException(typeof(Exceptions.InvalidEnderecoPropertyException))]
        public void TestSettingAInvalidBairro()
        {
            var bairro = "lucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucaslucas";
            var endereco = new Correios.Net.Models.Endereco();
            endereco.Bairro = bairro;
        }

        [TestMethod]
        public void TestSettingAValidBairro()
        {
            var bairro = "Jardim São Jorge";
            var endereco = new Correios.Net.Models.Endereco();
            endereco.Bairro = bairro;

            Assert.AreEqual(endereco.Bairro, bairro);
        }

        [TestMethod]
        [ExpectedException(typeof(Exceptions.InvalidEnderecoPropertyException))]
        public void TestSettingAInvalidStateUF()
        {
            var uf = "WW";
            var endereco = new Correios.Net.Models.Endereco();
            endereco.Estado = uf;
        }

        [TestMethod]
        public void TestSettingAValidStateUF()
        {
            var uf = "pr";
            var endereco = new Correios.Net.Models.Endereco();
            endereco.Estado = uf;

            Assert.AreEqual(endereco.Estado, uf.ToUpper());
        }
    }
}
