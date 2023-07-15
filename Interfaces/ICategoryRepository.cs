using Backend.Models;

namespace Backend.Interfaces
{
    public interface ICategory
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);

    }
}
