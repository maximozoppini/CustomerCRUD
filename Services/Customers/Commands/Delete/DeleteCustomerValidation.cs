using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Services.Customers.Commands.Create
{
    public class DeleteCustomerValidation : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerValidation()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.")
                .NotNull();
        }
    }
}
