using AutoMapper;
using IntegrationAPI.DTOs;
using IntegrationAPI.Models;

namespace IntegrationAPI.Mapping
{
    public class AdressMapping : Profile
    {
        public AdressMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<AdressResponse, AdressModel>().ReverseMap();
        }
    }
}
