using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCRUD.Services.Customers.Commands;
using SimpleCRUD.Services.Customers.Commands.Create;
using SimpleCRUD.Services.Customers.Querys;
using SimpleCRUD.Services.DTOs;

namespace SimpleCRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/customers
        [HttpGet]
        public async Task<ActionResult<List<CustomerDTO>>> GetAllCustomers()
        {
            var customers = await _mediator.Send(new GetAllCustomersQuery());
            return Ok(customers);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerCommand command)
        {
            if (command is null) return BadRequest();

            var response = await _mediator.Send(command);

            if (response.succcess)
            {
                return Ok(response.Data);
            }

            return BadRequest(response);
        }

        // PUT: api/customers/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<CustomerDTO>> UpdateCustomer(int id, [FromBody] UpdateCustomerCommand command)
        {
            if (command is null) return BadRequest();

            if (id != command.Id)
            {
                return BadRequest("Customer ID mismatch.");
            }

            var result = await _mediator.Send(command);
            return Ok(result.Data);
        }

        // DELETE: api/customers/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteCustomer(int id)
        {
            var result = await _mediator.Send(new DeleteCustomerCommand { Id = id });
            return Ok(result);
        }

    }
}
