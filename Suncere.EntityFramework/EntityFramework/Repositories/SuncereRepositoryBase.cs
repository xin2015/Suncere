using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Suncere.EntityFramework.Repositories
{
    public abstract class SuncereRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SuncereDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SuncereRepositoryBase(IDbContextProvider<SuncereDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SuncereRepositoryBase<TEntity> : SuncereRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SuncereRepositoryBase(IDbContextProvider<SuncereDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
