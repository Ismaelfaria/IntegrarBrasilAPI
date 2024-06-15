using IntegrationAPI.DTOs;
using IntegrationAPI.Models;
using IntegrationAPI.Models.CNPJ;

namespace IntegrationAPI.Interfaces
{
    public interface ICnpjService
    {

        Task<ResponseGenerico<CnpjModel>> BuscarCNPJ(string cnpj);

    }
}
