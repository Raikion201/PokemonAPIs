using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);

        bool DeleteCategory(Category category);
        public bool DeleteCategory(Category category)
        {
            _context.Remove(category);
            return Save();
        }
        bool Save();

    }
}
