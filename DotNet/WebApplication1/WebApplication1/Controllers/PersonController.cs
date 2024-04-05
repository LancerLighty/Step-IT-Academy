using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        [HttpGet("Get")]
        public IActionResult Get(int id) { 
            Person? person = _personRepository.Get(id);
            return Ok(person);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        { 
            List<Person> persons = _personRepository.GetAll();
            return Ok(persons);
        }
        [HttpPost("Create")]
        public IActionResult Create(Person person)
        {
            List<Person> persons = _personRepository.Create(person);
            return Ok(persons);
        }

    }
}
