using Country.Models;

namespace Country.Services
{
    public interface ICountryRepository
    {
        CountryDto Get(int id);
        List<CountryDto> GetAll(string? countryName, int? countryTeritory, string? countryContinent);
        void Create(CreateCountryDto employee);
        void Delete(int id);
        void Update(UpdateCountryDto employee);

    }
}
