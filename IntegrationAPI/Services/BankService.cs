using AutoMapper;
using IntegrationAPI.DTOs;
using IntegrationAPI.Interfaces;

namespace IntegrationAPI.Services
{
    public class BankService : IBankService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BankService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<BankResponse>>> BuscarTodos()
        {
            var bancos = await _brasilApi.BuscarTodosBancos();
            return _mapper.Map<ResponseGenerico<List<BankResponse>>>(bancos);
        }

        public async Task<ResponseGenerico<BankResponse>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilApi.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenerico<BankResponse>>(banco);
        }
    }
}
