using BlogWebsite.Core.Entities;

namespace BlogWebsite.Core.Repository;

public interface IRepository<TEntity, TId> where TEntity: Entity<TId> ,new()
{
    
}