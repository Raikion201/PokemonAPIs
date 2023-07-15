using AutoMapper;
using Backend.Dto;
using Backend.Models;

namespace Backend.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();


        }
    }
}
