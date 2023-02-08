using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem : PersonItem
    {
        public UserItem() 
        {
            IsActived = true;
        }
        public string userId { get; set; }
        public int IdRol { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool IsActived { get; set; }
        private string EncryptedPassword { get; set; }
    }
}
