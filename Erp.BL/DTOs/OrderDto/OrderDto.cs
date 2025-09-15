using Erp.BL.DTOs;
using Erp.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Erp.BL.OrderItemDtos;

namespace Erp.BL.DTOs.OrderDto
{
    public class OrderDto
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemDto> Items { get; set; }
    }
}