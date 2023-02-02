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
        public string UserName { get; set; }
        public bool IsActived { get; set; }
        private string EncryptedPassword { get; set; }
    }
}
