using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using RegistrationAutoAssignment.Entities.BPSInterface;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Repositories
{
    public abstract class GenericRepository<TEntity> :
      IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly BPSInterfaceEntities DbContext;
        protected DbContext Context { get; }

        protected DbConnection CntxDbConnect { get; }


        /// <summary>
        /// Create generic repository using ExtractAspenContext. 
        /// </summary>
        /// <param name="context"></param>
        protected GenericRepository(BPSInterfaceEntities context)
        {
            DbContext = context;
        }
        /// <summary>
        /// Create repository with DbConnection injection.
        /// </summary>
        /// <param name="cntxDbConnect"></param>
        protected GenericRepository(DbConnection cntxDbConnect)
        {
            CntxDbConnect = cntxDbConnect;
            DbContext = new BPSInterfaceEntities(cntxDbConnect);
        }

        /// <summary>
        /// Create repository using DbContext injection.
        /// </summary>
        /// <param name="context"></param>
        protected GenericRepository(DbContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Repository taking the unit of work to set the context
        /// </summary>
        /// <param name="unitOfWork"></param>
        protected GenericRepository(IUnitOfWork unitOfWork)
        {
            DbContext = unitOfWork.CreatedContext as BPSInterfaceEntities;
        }

        public IQueryable<TEntity> GetAll()
        {
            var query = DbContext.Set<TEntity>();
            return query;
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            var query = DbContext.Set<TEntity>().Where(predicate);
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