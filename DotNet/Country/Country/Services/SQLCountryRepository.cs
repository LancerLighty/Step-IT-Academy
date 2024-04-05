using System;
using Country.Models;
using Microsoft.EntityFrameworkCore;
namespace Country.Services
{
    public class SQLCountryRepository : ICountryRepository
    {
        private AppDbContext _context;

        public SQLCountryRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(CreateCountryDto countryDto)
        {
            CountryModel country = new CountryModel
            {
                CountryName = countryDto.CountryName,
                CountryTeritory = countryDto.CountryTeritory,
                CountryContinent = countryDto.CountryContinent,
                LanguageId = countryDto.LanguageId
            };

            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            CountryModel? country = _context.Countries.FirstOrDefault(x => x.Id == id);

            if (country == null)
            {
                throw new Exception("Employee was not found");
            }

            _context.Countries.Remove(country);
            _context.SaveChanges();
        }

        public CountryDto Get(int id)
        {
            CountryModel? country = _context.Countries.Include(x => x.Language).FirstOrDefault(x => x.Id == id);

            CountryDto employeeDto = new CountryDto
            {
                CountryName = country.CountryName,
                CountryTeritory = country.CountryTeritory,
                CountryContinent = country.CountryContinent
            };

            return employeeDto;
        }

        public List<CountryDto> GetAll(string? countryName, int? countryTeritory, string? countryContinent)
        {
            var employess = _context.Countries.AsQueryable();

            if (!string.IsNullOrEmpty(countryName))
            {
                employess = employess.Where(x => x.CountryName.Contains(countryName));
            }

            if (!string.IsNullOrEmpty(countryContinent))
            {
                employess = employess.Where(x => x.CountryContinent.Contains(countryContinent));
            }

            if (countryTeritory.HasValue)
            {
                employess = employess.Where(x => x.CountryTeritory == countryTeritory);
            }

            var CountriesDto = new List<CountryDto>();

            var groupedCountries = employess.ToList().GroupBy(x => x.Language.Name);

            foreach (var group in groupedCountries)
            {
                foreach (var employee in group)
                {
                    CountriesDto.Add(new CountryDto
                    {
                        CountryName = employee.CountryName,
                        CountryTeritory = employee.CountryTeritory,
                        CountryContinent = employee.CountryContinent,
                        LanguageName = employee.Language.Name
                    });
                }
            }

            return CountriesDto.ToList();

        }

        public void Update(UpdateCountryDto employeeDto)
        {
            CountryModel? existingEmployee = _context.Countries.FirstOrDefault(x => x.Id == employeeDto.Id);

            if (existingEmployee != null)
            {
                existingEmployee.CountryName = employeeDto.CountryName;
                existingEmployee.CountryContinent = employeeDto.CountryContinent;
                existingEmployee.CountryTeritory = employeeDto.CountryTeritory;
                existingEmployee.LanguageId = employeeDto.LanguageId;
            }

            _context.SaveChanges();
        }
    }
}
