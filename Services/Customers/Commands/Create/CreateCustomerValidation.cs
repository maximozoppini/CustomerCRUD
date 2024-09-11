using FluentValidation;
using SimpleCRUD.Services.Customers.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Services.Customers.Commands
{
    public class CreateCustomerValidation : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerValidation()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .NotNull();
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .NotNull();
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("A valid email address is required.")
                .NotNull();
        }
    }
}
