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

namespace SimpleCRUD.Services.Customers.Commands.Create
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, BaseResponse<CustomerDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepo;

        public UpdateCustomerHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepo = customerRepository;
        }

        public async Task<BaseResponse<CustomerDTO>> Handle(UpdateCustomerCommand command, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<CustomerDTO>();
            try
            {
                var customer = await _customerRepo.GetByIdAsync(command.Id);
                if (customer == null)
                {
                    throw new Exception("Customer not found");
                }

                customer.FirstName = command.FirstName;
                customer.LastName = command.LastName;
                customer.Email = command.Email;
                customer.Modify = DateTime.UtcNow;

                response.Data = _mapper.Map<CustomerDTO>(await _customerRepo.UpdateAsync(customer));
                response.succcess = true;
                response.Message = "Update succeed!";

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

    }
}
