using System;
using Refit;
using IbgeClient.Specification;

namespace IbgeClient
{
    public sealed class IbgeClientFactory
    {
        public static readonly String BaseUrl = "https://servicodados.ibge.gov.br/api/v1/localidades";

        private IbgeClientFactory() 
        {

        }

        public static IIbgeAPI IbgeClient { get; private set; }

        static IbgeClientFactory()
        {
            IbgeClient = RestService.For<IIbgeAPI>(BaseUrl);
        }
    }
}