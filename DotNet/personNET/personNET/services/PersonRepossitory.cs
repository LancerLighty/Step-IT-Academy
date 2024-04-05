using personNET.models;

namespace personNET.services
{
    public class PersonRepossitory : IPersonRepossitory
    {
        List<Person> persons = new List<Person>();

        public void Create(CreatePersonDto personDto)
        {
            Person person = new Person
            {
                FirstName = personDto.FirstName,
                LastName = personDto.LastName,
                Age = personDto.Age,
                Salary = personDto.Salery
            };
            persons.Add(person);
        }

        public void Delete(int id)
        {
            Person? person = persons.FirstOrDefault(x => x.Id == id);
            if (person == null)
            {
                throw new Exception("Person not found");
            }
            persons.Remove(person);
        }
        public PersonDto Get(int id)
        {
            Person? person = persons.FirstOrDefault(x => x.Id == id);
            PersonDto personDto = new PersonDto
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Age = person.Age
            };
            if (personDto == null)
            {
                throw new Exception("person not found");
            }
            return personDto;
        }

        public List<PersonDto> GetAll(string? firstname, string? lastname, int? age)
        {
            var personDto = persons.Select(x => new PersonDto
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age
            }).ToList();
            return personDto;
        }

        public void Update(UpdatePersonDto personDto)
        {
            Person? existPerson = persons.FirstOrDefault(x => x.Id == personDto.Id);
            if (existPerson != null) {
                existPerson.FirstName = personDto.FirstName;
                existPerson.LastName = personDto.LastName;
                existPerson.Age = personDto.Age;
                existPerson.Salary = personDto.Salary;
            }

        }
    }
}
