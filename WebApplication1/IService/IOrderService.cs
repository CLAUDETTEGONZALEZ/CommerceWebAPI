using Entities.Entities;

namespace APIService.IService
{
    public interface IOrderService
    {
        List<OrderItem> GetAllOrders();
        int InsertOrder(OrderItem orderItem);
        void UpdateOrder(OrderItem orderItem);
        void DeleteOrder(int id);
    }
}
