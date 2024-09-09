using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCRUD.Services.Customers.Commands;

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

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerCommand command)
        {
            if (command is null) return BadRequest();

            var response = await _mediator.Send(command);
            
            if (response.succcess)
            {
                return Ok(response);
            }

            return BadRequest(response); ;
        }
    }
}
