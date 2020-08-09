using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Yerebakan.CQRS.Api.Commands;
using Yerebakan.CQRS.Api.Models;
using Yerebakan.CQRS.Api.Queries;
using Yerebakan.CQRS.Core.Commands;
using Yerebakan.CQRS.Core.Queries;

namespace Yerebakan.CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IQueryBus _queryBus;
        private readonly ICommandBus _commandBus;

        public HomeController(IQueryBus queryBus, ICommandBus commandBus)
        {
            _queryBus = queryBus;
            _commandBus = commandBus;
        }

        [HttpGet("customers")]
        public async Task<IActionResult> GetCustomers()
        {
            return Ok(await _queryBus.Send<CustomerList, CustomerList>(new CustomerList()));
        }

        [HttpGet("customer/{Id}")]
        public async Task<IActionResult> GetCustomerById([FromRoute] CustomerById customerById)
        {
            return Ok(await _queryBus.Send<CustomerById, Customer>(customerById));
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddCustomer([FromBody] CreateCustomer createCustomer)
        {
            return Ok(_commandBus.Send(createCustomer));
        }
    }
}
