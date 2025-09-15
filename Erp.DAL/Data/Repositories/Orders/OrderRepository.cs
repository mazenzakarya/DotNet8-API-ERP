using Erp.DAL.Data.ContractorsContext;
using Erp.DAL.Data.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DAL.Data.Repositories.Orders
{
    public class OrderRepository : IOrdersRepository
    {
        private readonly ErpContext db;

        public OrderRepository(ErpContext db)
        {
            this.db = db;
        }

        public void CreateOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }

        public void DeleteOrder(Guid id)
        {
            var orderToDelete = GetOrderById(id);
            if (orderToDelete != null)
            {
                db.Orders.Remove(orderToDelete);
                db.SaveChanges();
            }
        }

        public Order GetOrderById(Guid id)
        {
            var orderById = db.Orders.Find(id);
            return orderById;
        }

        public List<Order> GetOrders()
        {
            var getAllOrders = db.Orders.ToList();
            return getAllOrders;
        }

        public void UpdateOrder(Guid id, Order order)
        {
            var current = GetOrderById(id);
            if (current != null)
            {
                current.OrderDate = order.OrderDate;
                current.TotalAmount = order.TotalAmount;
                current.UserId = order.UserId;
                db.SaveChanges();
            }
        }
    }
}