using WebApplication1.models;

namespace WebApplication1.Services
{
    public class PersonReporitory : IPersonRepository
    {
        List<Person> persons = new List<Person>();

        public List<Person> Create(Person person)
        {
            persons.Add(person);
            return persons;
        }

        public Person Get(int id)
        {
            Person? person = persons.FirstOrDefault(x => x.Id == id);
            if(person == null)
            {
                throw new Exception("person not found");
            }
            return person;
        }

        public List<Person> GetAll()
        {
            return persons;
        }
    }
}
