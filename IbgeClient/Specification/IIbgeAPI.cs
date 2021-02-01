using IbgeClient.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IbgeClient.Specification
{
    public interface IIbgeAPI
    {
        [Get("/distritos")]
        Task<IList<Distrito>> GetDistritosAsync();

        [Get("/municipios")]
        Task<IList<Municipio>> GetMunicipiosAsync();

        [Get("/microrregioes")]
        Task<IList<Microrregiao>> GetMicrorregioesAsync();

        [Get("/mesorregioes")]
        Task<IList<Mesorregiao>> GetMesorregioesAsync();

        [Get("/estados")]
        Task<IList<Estado>> GetEstadosAsync();

        [Get("/regioes")]
        Task<IList<Regiao>> GetRegioesAsync();
    }
}