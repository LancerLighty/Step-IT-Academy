using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using personNET.models;
using personNET.services;

namespace personNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepossitory _personRepossitory;

        public PersonsController(IPersonRepossitory personRepossitory)
        {
            _personRepossitory = personRepossitory;
        }
        [HttpGet("GetAll")]
        public IActionResult Get(string? firstname = null, string? lastname = null, int? age = null)
        {
            List<PersonDto> persons = _personRepossitory.GetAll(firstname, lastname, age);
            return Ok(persons);
        }
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            PersonDto? result = _personRepossitory.Get(id);
            return Ok(result);
        }
        [HttpPost("Create")]
        public IActionResult Create(CreatePersonDto person)
        {
             _personRepossitory.Create(person);
            return Ok("succesfully created");
        }
        [HttpPut("Update")]
        public IActionResult Update(UpdatePersonDto person)
        {
            _personRepossitory.Update(person);
            return Ok("succesfully updated");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _personRepossitory.Delete(id);
            return Ok("succesfully deleted");
        }
    }
}
