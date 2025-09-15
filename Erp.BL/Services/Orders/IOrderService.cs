using Erp.BL.DTOs.OrderDto;
using Erp.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BL.Services.Orders
{
    public interface IOrderService
    {
        List<OrderDto> GetOrders();

        OrderDto GetOrderById(Guid id);

        void CreateOrder(OrderDto order);

        void UpdateOrder(Guid id, OrderDto order);

        void DeleteOrder(Guid id);
    }
}