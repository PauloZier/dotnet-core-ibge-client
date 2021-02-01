using NUnit.Framework;
using IbgeClient;
using IbgeClient.Models;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDistritos()
        {
            IList<Distrito> retorno = IbgeClientFactory.IbgeClient.GetDistritos().Result;

            Assert.Pass();
        }

        [Test]
        public void TestMunicipios()
        {
            IList<Municipio> retorno = IbgeClientFactory.IbgeClient.GetMunicipios().Result;

            Assert.Pass();
        }

        [Test]
        public void TestMicrorregioes()
        {
            IList<Microrregiao> retorno = IbgeClientFactory.IbgeClient.GetMicrorregioes().Result;

            Assert.Pass();
        }

        [Test]
        public void TestMesorregioes()
        {
            IList<Mesorregiao> retorno = IbgeClientFactory.IbgeClient.GetMesorregioes().Result;

            Assert.Pass();
        }

        [Test]
        public void TestEstados()
        {
            IList<Estado> retorno = IbgeClientFactory.IbgeClient.GetEstados().Result;

            Assert.Pass();
        }

        [Test]
        public void TestRegioes()
        {
            IList<Regiao> retorno = IbgeClientFactory.IbgeClient.GetRegioes().Result;

            Assert.Pass();
        }
    }
}