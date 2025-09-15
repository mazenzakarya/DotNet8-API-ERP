using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Erp.BL.Services.Orders;
using Erp.BL.DTOs.OrderDto;

namespace Erp.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orders = _orderService.GetOrders();
            return Ok(orders);
        }

        [HttpPost]
        public IActionResult Create([FromBody] OrderDto order)
        {
            _orderService.CreateOrder(order);
            return Ok();
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var order = _orderService.GetOrderById(id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult Update(Guid id, [FromBody] OrderDto order)
        {
            var existingOrder = _orderService.GetOrderById(id);
            if (existingOrder == null) return NotFound();
            _orderService.UpdateOrder(id, order);
            return Ok();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var existingOrder = _orderService.GetOrderById(id);
            if (existingOrder == null) return NotFound();
            _orderService.DeleteOrder(id);
            return Ok();
        }
    }
}