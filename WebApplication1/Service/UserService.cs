using APIService.IService;
using Entities.Entities;

namespace APIService.Service
{
    public class UserService : IUserService
    {
        private readonly IUserService _userLogic;
        public UserService(IUserService userLogic)
        {
            _userLogic = userLogic;
        }
        public int InsertUser(UserItem userItem)
        {
            _userLogic.InsertUserItem(userItem);
            return userItem.Id;
        }

    }
}
