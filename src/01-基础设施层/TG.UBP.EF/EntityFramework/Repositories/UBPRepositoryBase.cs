using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TG.UBP.EntityFramework.Repositories
{
    public abstract class UBPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<UBPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected UBPRepositoryBase(IDbContextProvider<UBPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class UBPRepositoryBase<TEntity> : UBPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected UBPRepositoryBase(IDbContextProvider<UBPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
