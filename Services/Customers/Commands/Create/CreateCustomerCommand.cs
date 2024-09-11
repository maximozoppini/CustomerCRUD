using MediatR;
using SimpleCRUD.Entities;
using SimpleCRUD.Services.Commons.Bases;
using SimpleCRUD.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Services.Customers.Commands.Create
{
    public class CreateCustomerCommand : IRequest<BaseResponse<CustomerDTO>>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

    }
}
