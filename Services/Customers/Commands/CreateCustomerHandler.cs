using AutoMapper;
using Azure.Core;
using FluentValidation;
using MediatR;
using SimpleCRUD.Entities;
using SimpleCRUD.Entities.DBContext;
using SimpleCRUD.Repositories.Interfaces;
using SimpleCRUD.Services.Commons.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Services.Customers.Commands
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, BaseResponse<Customer>>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepo;

        public CreateCustomerHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepo = customerRepository;
        }

        public async Task<BaseResponse<Customer>> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<Customer>();
            try
            {
                var customer = _mapper.Map<Customer>(command);
                customer.Created = DateTime.UtcNow;
                customer.Modify = DateTime.UtcNow;

                response.Data = await _customerRepo.Add(customer);
                response.succcess = true;
                //if (response.Data)
                //{
                //    response.succcess = true;
                //    response.Message = "Create succeed!";
                //}
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

    }
}
