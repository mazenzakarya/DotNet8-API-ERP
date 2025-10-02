using Erp.BL.DTOs.OrderDto;
using Erp.DAL.Data.Models;

namespace Erp.BL.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrdersRepository _repo;

        public OrderService(IOrdersRepository repo)
        {
            _repo = repo;
        }

        public void CreateOrder(OrderDto order)
        {
            _repo.CreateOrder(new Order
            {
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                UserId = order.UserId
            });
        }

        public void DeleteOrder(Guid id)
        {
            _repo.DeleteOrder(id);
        }

        public OrderDto GetOrderById(Guid id)
        {
            var order = _repo.GetOrderById(id);
            if (order == null) return null;

            return new OrderDto
            {
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                UserId = order.UserId
            };
        }

        public List<OrderDto> GetOrders()
        {
            var orders = _repo.GetOrders();
            return orders.Select(order => new OrderDto
            {
                OrderDate = order.OrderDate,
                TotalAmount = order.TotalAmount,
                UserId = order.UserId
            }).ToList();
        }

        public void UpdateOrder(Guid id, OrderDto order)
        {
            var existingOrder = _repo.GetOrderById(id);
            if (existingOrder != null)
            {
                existingOrder.OrderDate = order.OrderDate;
                existingOrder.TotalAmount = order.TotalAmount;
                existingOrder.UserId = order.UserId;
                _repo.UpdateOrder(id, existingOrder);
            }
        }
    }
}