﻿using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Repositories
{
    public abstract class GenericRepository<TEntity> :
      IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly ExtractAspenEntities DbContext;
        public DbContext Context { get; }

        public DbConnection CntxDbConnect { get; }


       /// <summary>
       /// Create generic repository using ExtractAspenContext. 
       /// </summary>
       /// <param name="context"></param>
        protected GenericRepository(ExtractAspenEntities context)
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
            DbContext = new ExtractAspenEntities(cntxDbConnect);
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
            DbContext = unitOfWork.CreatedContext as ExtractAspenEntities;
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