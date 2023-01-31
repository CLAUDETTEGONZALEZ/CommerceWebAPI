using APIService.IService;
using Entities.Entities;

namespace APIService.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderService _orderLogic;
        public OrderService(IOrderService orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public int InsertOrder(OrderItem orderItem) 
        {
            _orderLogic.InsertOrderItem(orderItem);
            return orderItem.Id;
        }
    }
}
