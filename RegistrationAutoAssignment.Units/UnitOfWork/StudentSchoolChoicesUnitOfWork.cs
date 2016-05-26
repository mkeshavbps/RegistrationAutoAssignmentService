using System;
using System.Collections;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;
using System.Data.Common;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories;

namespace RegistrationAutoAssignment.Units.UnitOfWork
{
    /// <summary>
    /// Student Choice unit of work.
    /// </summary>
    public class StudentSchoolChoicesUnitOfWork : IStudentSchoolChoicesUnitOfWork
    {
        private bool _disposed;

        #region "Get DbContext, repositories when needed"

        /// <summary>
        /// Aspen extracted entities.
        /// </summary>
        public ExtractAspenEntities Context { get; }

        public IRepository Repository { get; set; }

        public DbConnection CntxDbConnect { get; }

        /// <summary>
        /// Repositories specific to StudentSchoolChoices uow.
        /// </summary>
        internal Hashtable Repositories { get; set; } = new Hashtable();

        #endregion

        public StudentSchoolChoicesUnitOfWork(ExtractAspenEntities context)
        {
            Context = context;
            Repository = new SchoolChoiceRepository(context);
            Repositories?.Add("ISchoolChoicesRepository", Repository);
        }

        /// <summary>
        /// Creates an instance of the unit of work along with concrete context and repository implementations.
        /// </summary>
        public StudentSchoolChoicesUnitOfWork()
        {
            Repository = AddRepository(typeof(SchoolChoiceRepository));
            Context = Repository.AspenDbContext;
            Repositories?.Add("ISchoolChoicesRepository", Repository);
        }


        /// <summary>
        /// Creates an instance using the DbConnection.
        /// </summary>
        /// <param name="cntxDbConnect"></param>
        public StudentSchoolChoicesUnitOfWork(DbConnection cntxDbConnect)
        {
            CntxDbConnect = cntxDbConnect;
            Repository = new SchoolChoiceRepository(CntxDbConnect);
            Repositories?.Add("ISchoolChoicesRepository", Repository);
        }

        /// <summary>
        /// Creates an instance using the repository
        /// </summary>
        /// <param name="repository"></param>
        public StudentSchoolChoicesUnitOfWork(IRepository repository)
        {
            Context = repository.AspenDbContext;
            Repository = repository;
            Repositories?.Add("ISchoolChoicesRepository", Repository);
        }


        #region "IDisposable pattern"
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    Context?.Dispose();

            _disposed = true;
        }

        #endregion

        #region " Commented code - can be used later"

        /// <summary>
        /// Adds the repositories to the read only collection.
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// Adds the Unit of work to the read only collection.
        /// </summary>
        /// <returns></returns>
        //public IUnitOfWork AddUnitOfWork<T>() where T : class
        //{
        //    if (UnitOfWorks == null)
        //        UnitOfWorks = new Hashtable();

        //    var type = typeof(T).Name;

        //    if (UnitOfWorks.ContainsKey(type)) return (IUnitOfWork)UnitOfWorks[type];
        //    var unitOfWorkType = typeof(IUnitOfWork);

        //    var uowInstance =
        //        Activator.CreateInstance(unitOfWorkType
        //            .MakeGenericType(typeof(T)), UnitOfWork);

        //    UnitOfWorks.Add(type, uowInstance);

        //    return (IUnitOfWork)UnitOfWorks[type];
        //}

        #endregion
        public IRepository AddRepository(Type typeOfRepository)
        {
            if (Repositories == null)
                Repositories = new Hashtable();

            var type = typeOfRepository.Name;
            if (Repositories.ContainsKey(type)) return (IRepository)Repositories[type];

            var repositoryInstance =
                Activator.CreateInstance(typeOfRepository);
            Repositories.Add(type, repositoryInstance);

            return (IRepository)Repositories[type];
        }


        /// <summary>
        /// Persist the changes to the context and the database.
        /// </summary>
        /// <returns></returns>
        int IUnitOfWork.Save()
        {
            var returnedInt = Context.SaveChanges();
            return returnedInt;
        }
    }
}
