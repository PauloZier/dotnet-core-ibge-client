using IbgeClient.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IbgeClient.Specification
{
    public interface IIbgeAPI
    {
        [Get("/distritos")]
        Task<IList<Distrito>> GetDistritos();

        [Get("/municipios")]
        Task<IList<Municipio>> GetMunicipios();

        [Get("/microrregioes")]
        Task<IList<Microrregiao>> GetMicrorregioes();

        [Get("/mesorregioes")]
        Task<IList<Mesorregiao>> GetMesorregioes();

        [Get("/estados")]
        Task<IList<Estado>> GetEstados();

        [Get("/regioes")]
        Task<IList<Regiao>> GetRegioes();
    }
}