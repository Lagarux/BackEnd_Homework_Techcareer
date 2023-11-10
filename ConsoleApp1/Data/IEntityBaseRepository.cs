
namespace Zoo_Project.Data
{
    public interface IEntityBaseRepository <TEntity,TId>
    {
        void Add(TEntity entity);
        void Delete(TId id);
        List<TEntity> GetAll();
        TEntity? GetByID(TId id);
    }
}
