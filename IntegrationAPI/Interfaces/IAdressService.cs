using IntegrationAPI.DTOs;

namespace IntegrationAPI.Interfaces
{
    public interface IAdressService
    {
        Task<ResponseGenerico<AdressResponse>> BuscarEndereco(string cep);
    }
}
