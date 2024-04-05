using Country.Models;
using Country.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Country.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository employeeRepository)
        {
            _countryRepository = employeeRepository;
        }
        [Authorize]
        [HttpGet("GetAll")]
        public IActionResult GetAll(string? countryName = null, string? countryTeritory = null, int? countryContinent = null)
        {
            List<CountryDto> employees = _countryRepository.GetAll(countryName, countryContinent, countryTeritory);
            return Ok(employees);
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            CountryDto? result = _countryRepository.Get(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateCountryDto employee)
        {
            _countryRepository.Create(employee);
            return Ok("Succesfully Created");
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateCountryDto employee)
        {
            _countryRepository.Update(employee);
            return Ok("Succesfully Uptadet");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _countryRepository.Delete(id);
            return Ok("Succesfully Deleted");
        }
    }
}
