namespace UserfulArchitecture.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using UsefulArchitecture.Domain;

    public interface IRepository
    {
        TEntity FindById<TEntity>(int id) where TEntity : BaseEntity;

        Task<TEntity> FindByIdAsync<TEntity>(int id) where TEntity : BaseEntity;

        IList<TEntity> List<TEntity>() where TEntity : BaseEntity;

        IList<TEntity> List<TEntity>(Expression<Func<TEntity, bool>> ex) where TEntity : BaseEntity;

        IQueryable<TEntity> Queryable<TEntity>() where TEntity : BaseEntity;

        void Add<TEntity>(TEntity entity) where TEntity : BaseEntity;

        void Update<TEntity>(TEntity entity) where TEntity : BaseEntity;

        void Reomove<TEntity>(TEntity entity) where TEntity : BaseEntity;

        void SaveChanges();

        Task SaveChangesAsync();
    }
}