using CQRS.MediatR.Application.Commands;
using CQRS.MediatR.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.MediatR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult Get(GetOrder query) => Ok(_mediator.Send(query));

        [HttpPost]
        public ActionResult Create([FromBody] CreateOrder command)
        {
            _mediator.Send(command);

            return Ok();
        }
    }
}
