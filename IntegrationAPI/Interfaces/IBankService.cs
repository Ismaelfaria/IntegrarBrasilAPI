using IntegrationAPI.DTOs;

namespace IntegrationAPI.Interfaces
{
    public interface IBankService
    {
        Task<ResponseGenerico<List<BankResponse>>> BuscarTodos();
        Task<ResponseGenerico<BankResponse>> BuscarBanco(string codigoBanco);
    }
}
