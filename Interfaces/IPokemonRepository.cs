using Backend.Models;

namespace Backend.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons(); 
    }
}
