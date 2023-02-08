using APIService.IService;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace APIService.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic;
        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public int InsertOrder(OrderItem orderItem)
        {
            _orderLogic.InsertOrderItem(orderItem);
            return orderItem.Id;
        }
        public List<OrderItem> GetAllOrders()
        {
            return _orderLogic.GetAllOrders();
        }
        public void UpdateOrder(OrderItem orderItem)
        {
            _orderLogic.UpdateOrder(orderItem);
        }
        public void DeleteOrder(int id)
        {
            _orderLogic.DeleteOrder(id);
        }
    }
}
