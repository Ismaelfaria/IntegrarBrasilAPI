using AutoMapper;
using IntegrationAPI.DTOs;
using IntegrationAPI.Interfaces;

namespace IntegrationAPI.Services
{
    public class AdressService : IAdressService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public AdressService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<AdressResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCEP(cep);

            return _mapper.Map<ResponseGenerico<AdressResponse>>(endereco);
        }
    }
}
