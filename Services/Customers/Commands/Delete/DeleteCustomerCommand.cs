using MediatR;
using SimpleCRUD.Entities;
using SimpleCRUD.Services.Commons.Bases;
using SimpleCRUD.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Services.Customers.Commands
{
    public class DeleteCustomerCommand : IRequest<BaseResponse<int>>
    {
        public int Id { get; set; }


    }
}
