using AutoMapper;
using SimpleCRUD.Entities;
using SimpleCRUD.Services.Customers.Commands.Create;
using SimpleCRUD.Services.DTOs;

namespace SimpleCRUD.Services.Commons.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
            //CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
        }
    }
}
