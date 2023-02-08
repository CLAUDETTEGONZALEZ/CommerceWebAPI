using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        List<UserItem> GetAllUsers();
        void DeleteUser(int userId);
        void UpdateUser(UserItem userItem);
        int InsertUserItem(UserItem userItem);
    }
}
