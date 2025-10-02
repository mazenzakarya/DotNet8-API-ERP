using Erp.BL.DTOs.OrderDto;

namespace Erp.BL.Services.Orders
{
    public interface IOrderService
    {
        public void CreateOrder(OrderDto order);

        public List<OrderDto> GetOrdersByUserId(Guid userId);

        public OrderDto GetOrderById(Guid orderId);

        public void UpdateOrder(OrderDto order);

        public void DeleteOrder(Guid orderId);
    }
}