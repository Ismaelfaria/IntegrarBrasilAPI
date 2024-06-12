using IntegrationAPI.DTOs;
using IntegrationAPI.Models;

namespace IntegrationAPI.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<AdressModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BankModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BankModel>> BuscarBanco(string codigoBanco);
    }
}
