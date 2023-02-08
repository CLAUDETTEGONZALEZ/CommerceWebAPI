using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        List<OrderItem> GetAllOrders();
        void DeleteOrder(int orderId);
        void UpdateOrder(OrderItem orderItem);
        int InsertOrderItem(OrderItem orderItem);
    }
}
