using AutoMapper;
using SimpleCRUD.Entities;
using SimpleCRUD.Services.Customers.Commands;
using SimpleCRUD.Services.DTOs;

namespace SimpleCRUD.Services.Commons.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Customer, AddCustomerDTO>().ReverseMap();
            //CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            //CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
        }
    }
}
