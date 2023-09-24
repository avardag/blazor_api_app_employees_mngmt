using BlazorHRM.Shared.Domain;

namespace BlazorHRM.Api.Data;
public interface ICountryRepository
{
    IEnumerable<Country> GetAllCountries();
    Country GetCountryById(int countryId);
}
