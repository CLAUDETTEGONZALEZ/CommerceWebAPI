using APIService.IService;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace APIService.Service
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        public int InsertUser(UserItem userItem)
        {
            _userLogic.InsertUserItem(userItem);
            return userItem.Id;
        }
        public List<UserItem> GetAllUsers() 
        {
            return _userLogic.GetAllUsers();
        }
        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }
        public void DeleteUser(int userId)
        {
            _userLogic.DeleteUser(userId);
        }
    }
}
