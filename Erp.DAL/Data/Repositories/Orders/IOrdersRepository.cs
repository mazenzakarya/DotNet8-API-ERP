using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.DAL.Data.Models;

namespace Erp.DAL.Data.Repositories.Orders
{
    public interface IOrdersRepository
    {
        // Define methods for managing orders, e.g., GetOrders, GetOrderById, CreateOrder, UpdateOrder, DeleteOrder
        List<Order> GetOrders();

        Order GetOrderById(Guid id);

        void CreateOrder(Order order);

        void UpdateOrder(Guid id, Order order);

        void DeleteOrder(Guid id);
    }
}