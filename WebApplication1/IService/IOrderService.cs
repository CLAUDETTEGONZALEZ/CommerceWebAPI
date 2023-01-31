using Entities.Entities;

namespace APIService.IService
{
    public interface IOrderService
    {
        List<OrderItem> GetAllOrders();
        int InsertOrder(OrderItem orderItem);
    }
}
