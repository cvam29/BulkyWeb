namespace Bulky.DataAccess.Repository.Interfaces;
public interface IUnitOfWork
{
    ICategoryRepository CategoryRepository { get; }

    void Save();
}
