using Backend.Models;

namespace Backend.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromAcountry(int countryId);
        bool CountryExists(int id);
        
    }
}
