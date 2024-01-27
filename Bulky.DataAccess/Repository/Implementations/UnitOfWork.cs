using Bulky.DataAccess.Repository.Interfaces;

namespace Bulky.DataAccess.Repository.Implementations;
public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
{
    public ICategoryRepository CategoryRepository { get; private set; } = new CategoryRepository(context);

    public void Save()
    {
        context.SaveChanges();
    }
}
