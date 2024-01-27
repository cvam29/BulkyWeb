using Bulky.DataAccess.Repository.Interfaces;
using Bulky.Models;

namespace Bulky.DataAccess.Repository.Implementations;
public class CategoryRepository(ApplicationDbContext _context) : Repository<Category>(_context),ICategoryRepository
{
  
    public void Update(Category category)
    {
       _context.Update(category);
    }
}
