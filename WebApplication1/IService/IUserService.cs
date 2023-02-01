using Entities.Entities;

namespace APIService.IService
{
    public interface IUserService
    {
        List<UserItem> GetAllUsers();
        int InsertUser(UserItem userItem);
        
    }
}
