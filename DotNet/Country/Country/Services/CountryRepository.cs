using Country.Models;
using System.Xml.Linq;
namespace Country.Services
{
    public class CountryRepository : ICountryRepository
    {
        private List<CountryModel> countries = new List<CountryModel>();

        public void Create(CreateCountryDto countryDto)
        {
            CountryModel employee = new CountryModel
            {
                CountryName = countryDto.CountryName,
                CountryTeritory = countryDto.CountryTeritory,
                CountryContinent = countryDto.CountryContinent
            };

            countries.Add(employee);
        }

        public void Delete(int id)
        {
            CountryModel? country = countries.FirstOrDefault(x => x.Id == id);

            if (country == null)
            {
                throw new Exception("employee not found");
            }

            countries.Remove(country);
        }

        public CountryDto Get(int id)
        {
            CountryModel? country = countries.FirstOrDefault(x => x.Id == id);

            CountryDto countryDto = new CountryDto
            {
                CountryName = country.CountryName,
                CountryTeritory = country.CountryTeritory,
                CountryContinent = country.CountryContinent
            };

            if (countryDto == null)
            {
                throw new Exception("employee not found");
            }

            return countryDto;
        }

        public List<CountryDto> GetAll(string? countryName, int? countryTeritory, string? countryContinent)
        {
            var countryDto = countries.Select(x => new CountryDto
            {
                CountryName = x.CountryName,
                CountryTeritory = x.CountryTeritory,
                CountryContinent = x.CountryContinent,

            }).ToList();

            return countryDto;
        }

        public void Update(UpdateCountryDto employeeDto)
        {
            CountryModel? existingEmployee = countries.FirstOrDefault(x => x.Id == employeeDto.Id);

            if (existingEmployee != null)
            {
                existingEmployee.CountryName = employeeDto.CountryName;
                existingEmployee.CountryTeritory = employeeDto.CountryTeritory;
                existingEmployee.CountryContinent = employeeDto.CountryContinent;
            }
        }
    }
}
