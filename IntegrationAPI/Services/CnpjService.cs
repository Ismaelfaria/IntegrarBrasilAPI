using AutoMapper;
using IntegrationAPI.DTOs;
using IntegrationAPI.Interfaces;
using IntegrationAPI.Models.CNPJ;

namespace IntegrationAPI.Services
{
    public class CnpjService: ICnpjService
    {
        private readonly IBrasilApi _brasilApi;

        public CnpjService(IBrasilApi brasilApi)
        {
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<CnpjModel>> BuscarCNPJ(string cnpj)
        {
            var RespCnpj = await _brasilApi.BuscarCNPJ(cnpj);
            return RespCnpj;
        }
    }
}
