using APIService.IService;
using Entities.Entities;
using Logic.ILogic;

namespace APIService.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonLogic _personLogic;
        public PersonService(IPersonLogic personLogic)
        {
            _personLogic = personLogic;
        }
        public int InsertPerson(PersonItem personItem)
        {
            _personLogic.InsertPersonItem(personItem);
            return personItem.Id;
        }
    }
}
