using System.Collections.Generic;
using System.Linq;

namespace CrudEFCorePeopleVideoAula.Models
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext context;

        public PersonRepository (DataContext context)
        {
            this.context= context;
        }

        public void Create(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.People.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Person> GetAll()
        {
            return context.People.ToList();
        }

        public Person GetById(int id)
        {
           return context.People.SingleOrDefault(x=>x.id==id);
        }

        public void Update(Person person)
        {
            var objPerson = GetById(person.id);
            objPerson.name = person.name;
            objPerson.address = person.address;

            context.SaveChanges();
        }
    }
}