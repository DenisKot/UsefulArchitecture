namespace UserfulArchitecture.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using UsefulArchitecture.Domain;
    public class Repository : IRepository
    {
        protected AppDatabaseContext Context;

        public Repository(AppDatabaseContext context)
        {
            this.Context = context;
        }

        public TEntity FindById<TEntity>(int id) where TEntity : BaseEntity
        {
            return this.Context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public async Task<TEntity> FindByIdAsync<TEntity>(int id) where TEntity : BaseEntity
        {
            return await this.Context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public IList<TEntity> List<TEntity>() where TEntity : BaseEntity
        {
            return this.Context.Set<TEntity>().ToList();
        }

        public IList<TEntity> List<TEntity>(Expression<Func<TEntity, bool>> ex) where TEntity : BaseEntity
        {
            return this.Context.Set<TEntity>().Where(ex).ToList();
        }

        public IQueryable<TEntity> Queryable<TEntity>() where TEntity : BaseEntity
        {
            return this.Context.Set<TEntity>().AsQueryable();
        }

        public void Add<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            this.Context.Set<TEntity>().Add(entity);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            this.Context.Entry(entity).State = EntityState.Modified;
        }

        public void Reomove<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            this.Context.Set<TEntity>().Remove(entity);
        }

        public void SaveChanges()
        {
            this.Context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await this.Context.SaveChangesAsync();
        }
    }
}