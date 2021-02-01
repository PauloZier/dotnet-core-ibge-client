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
            IList<Distrito> retorno = IbgeClientFactory.IbgeClient.GetDistritosAsync().Result;

            Assert.Pass();
        }

        [Test]
        public void TestMunicipios()
        {
            IList<Municipio> retorno = IbgeClientFactory.IbgeClient.GetMunicipiosAsync().Result;

            Assert.Pass();
        }

        [Test]
        public void TestMicrorregioes()
        {
            IList<Microrregiao> retorno = IbgeClientFactory.IbgeClient.GetMicrorregioesAsync().Result;

            Assert.Pass();
        }

        [Test]
        public void TestMesorregioes()
        {
            IList<Mesorregiao> retorno = IbgeClientFactory.IbgeClient.GetMesorregioesAsync().Result;

            Assert.Pass();
        }

        [Test]
        public void TestEstados()
        {
            IList<Estado> retorno = IbgeClientFactory.IbgeClient.GetEstadosAsync().Result;

            Assert.Pass();
        }

        [Test]
        public void TestRegioes()
        {
            IList<Regiao> retorno = IbgeClientFactory.IbgeClient.GetRegioesAsync().Result;

            Assert.Pass();
        }
    }
}