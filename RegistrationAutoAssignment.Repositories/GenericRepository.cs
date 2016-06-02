using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Repositories
{
    public class GenericRepository<TEntity> :
      IGenericRepository<TEntity> where TEntity : class
    {
        protected ExtractAspenEntities DbContext;

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            DbContext = unitOfWork.Context;
        }

        public IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = DbContext.Set<TEntity>();
            return query;
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = DbContext.Set<TEntity>().Where(predicate);
            return query;
        }

        public TEntity Add(TEntity entity)
        {
            return DbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbContext.Set<TEntity>().AddOrUpdate(entity);
        }
    }
}