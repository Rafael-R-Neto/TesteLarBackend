using AutoMapper;
using TesteLar.Application.DTO;
using TesteLar.Domain.Entities;

namespace TesteLar.Application.Configurations;

public class AutoMapperConfig: Profile
{
    public AutoMapperConfig()
    {
        CreateMap<PersonDTO, Person>().ReverseMap();
        CreateMap<PhoneDTO, Phone>().ReverseMap();
        CreateMap<PhoneTypeDTO, PhoneType>().ReverseMap();
    }
}
