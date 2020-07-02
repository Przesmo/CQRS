using CQRS.Manually.Application.Commands;
using CQRS.Manually.Application.Dispatchers;
using CQRS.Manually.Application.DTOs;
using CQRS.Manually.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Manually.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public OrdersController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public ActionResult CreateOrder([FromBody] CreateOrder command)
        {
            _dispatcher.Send(command);

            return Ok();
        }

        [HttpGet("{customerId}")]
        public ActionResult GetOrder([FromRoute] GetOrder query)
        {
            var order = _dispatcher.Query<GetOrder, OrderDto>(query);

            return Ok(order);
        }
    }
}