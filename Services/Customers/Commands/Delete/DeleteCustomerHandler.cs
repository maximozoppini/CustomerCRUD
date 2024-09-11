using AutoMapper;
using Azure.Core;
using FluentValidation;
using MediatR;
using SimpleCRUD.Entities;
using SimpleCRUD.Entities.DBContext;
using SimpleCRUD.Repositories.Interfaces;
using SimpleCRUD.Services.Commons.Bases;
using SimpleCRUD.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Services.Customers.Commands
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, BaseResponse<int>>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepo;

        public DeleteCustomerHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepo = customerRepository;
        }

        public async Task<BaseResponse<int>> Handle(DeleteCustomerCommand command, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<int>();
            try
            {
                var customer = await _customerRepo.GetByIdAsync(command.Id);
                if (customer == null)
                {
                    throw new Exception("Customer not found");
                }

                await _customerRepo.DeleteAsync(customer);
                response.Data = customer.Id;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

    }
}
