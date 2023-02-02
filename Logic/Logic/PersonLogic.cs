using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class PersonLogic : BaseContextLogic, IPersonLogic
    {
        public PersonLogic(ServiceContext serviceContext) : base(serviceContext)
        {
        }

        public int InsertPersonItem(PersonItem personItem)
        {
            _serviceContext.Persons.Add(personItem);
            _serviceContext.SaveChanges();
            return personItem.Id;
        }
    }
}
