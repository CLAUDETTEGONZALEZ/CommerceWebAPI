using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class RolItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Access { get; set; }
        public bool IsActive { get; set; }
    }
}
