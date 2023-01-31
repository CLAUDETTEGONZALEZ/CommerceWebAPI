using Entities.Entities;

namespace APIService.IService
{
    public interface IOrderService
    {
        int InsertOrder(OrderItem orderItem);
    }
}
