using WebApplication1.models;

namespace WebApplication1.Services
{
    public interface IPersonRepository
    {
        Person Get(int id);
        List<Person> GetAll();
        List<Person> Create(Person person);

    }
}
