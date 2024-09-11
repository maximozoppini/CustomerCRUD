using AutoMapper;
using MediatR;
using SimpleCRUD.Entities;
using SimpleCRUD.Repositories;
using SimpleCRUD.Repositories.Interfaces;
using SimpleCRUD.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Services.Customers.Querys
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, List<CustomerDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepo;

        public GetAllCustomersQueryHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepo = customerRepository;
        }

        public async Task<List<CustomerDTO>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<CustomerDTO>>((await _customerRepo.GetAllAsync()).ToList());
        }
    }

    public class GetAllCustomersQuery : IRequest<List<CustomerDTO>>
    {
    }

}
