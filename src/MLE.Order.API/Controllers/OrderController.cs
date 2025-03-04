using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MLE.IntegrationHandler.Events;
using MLE.Order.Application.Dtos;
using MLE.Order.Application.Interfaces.Services;

namespace MLE.Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IBus _bus;

        public OrderController(IOrderService orderService, IBus bus)
        {
            _orderService = orderService;
            _bus = bus;
        }

        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder(CreateOrderDto request, CancellationToken cancellationToken)
        {
            await _orderService.CreateOrder(request);
            await _bus.Publish(new OrderCreatedEvent{ Id = Guid.NewGuid()}, cancellationToken);
            return Ok();
        }
        [HttpGet("get-orders")]
        public async Task<IActionResult> GetOrders()
        {
            
            return Ok(await _orderService.GetAll());
        }
    }
}