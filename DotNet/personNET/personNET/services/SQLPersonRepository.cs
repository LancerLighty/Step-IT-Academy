using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using personNET.Controllers;
using personNET.models;

namespace personNET.services
{
    public class SQLPersonRepository : IPersonRepossitory

    {
        private AppDbContext _context;
        public SQLPersonRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Create(CreatePersonDto personDto)
        {
            Person person = new Person
            {
                FirstName = personDto.FirstName,
                LastName = personDto.LastName,
                Age = personDto.Age,
                Salary = personDto.Salery,
                NationalityId = personDto.NationalityId
        };
            _context.persons.Add(person);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Person? person = _context.persons.FirstOrDefault(x => x.Id ==  id);
            if(person == null)
            {
                throw new Exception();
            }
            _context.persons.Remove(person);
            _context.SaveChanges();
        }

        public PersonDto Get(int id)
        {
            Person? person = _context.persons.Include(x => x.Nationality).FirstOrDefault(x => x.Id == id);
            PersonDto personDto = new PersonDto
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Age = person.Age,
                NationName = person.Nationality.Name
            };
            return personDto;
        }

        public List<PersonDto> GetAll(string? firstname, string? lastname, int? age)
        {
            var persons = _context.persons.Include(x => x.Nationality).AsQueryable();
            if (!string.IsNullOrEmpty(firstname))
            {
                persons = persons.Where(x => x.FirstName.Contains(firstname));
            }
            if (!string.IsNullOrEmpty(lastname))
            {
                persons = persons.Where(x => x.LastName.Contains(lastname));
            }
            if (age.HasValue)
            {
                persons = persons.Where(x => x.Age == age);
            }
            var PersonsDto = persons.Select(x => new PersonDto
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                NationName = x.Nationality.Name
            }).ToList();
            return PersonsDto.ToList();
        }

        public void Update(UpdatePersonDto personDto)
        {
            Person? existingPerson = _context.persons.FirstOrDefault(x => x.Id == personDto.Id);
            if(existingPerson != null)
            {
                existingPerson.FirstName = personDto.FirstName;
                existingPerson.LastName = personDto.LastName;
                existingPerson.Age = personDto.Age;
                existingPerson.Salary = personDto.Salary;
                existingPerson.NationalityId = personDto.NationalityId;
            }
            _context.SaveChanges();
        }
    }
}
