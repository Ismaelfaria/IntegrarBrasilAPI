using AutoMapper;
using IntegrationAPI.DTOs;
using IntegrationAPI.Models;

namespace IntegrationAPI.Mapping
{
    public class BankMapping : Profile
    {
        public BankMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BankResponse, BankModel>() .ReverseMap();
        }
    }
}
