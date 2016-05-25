using System;
using System.Collections;
using RegistrationAutoAssignment.Entities;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;
using System.Data.Common;
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
        internal Hashtable Repositories { get; private set; }

        #endregion

        public StudentSchoolChoicesUnitOfWork(ExtractAspenEntities context)
        {
            Context = context;
            //Repository = AddRepository<ISchoolChoicesRepository>();
            Repository = AddRepository(typeof(SchoolChoiceRepository));
        }

        /// <summary>
        /// Creates an instance of the unit of work along with concrete context and repository implementations.
        /// </summary>
        public StudentSchoolChoicesUnitOfWork()
        {
            Context = new ExtractAspenEntities();
            //Repository = AddRepository<ISchoolChoicesRepository>();
            Repository = AddRepository(typeof(SchoolChoiceRepository));
        }


        /// <summary>
        /// Creates an instance using the DbConnection.
        /// </summary>
        /// <param name="cntxDbConnect"></param>
        public StudentSchoolChoicesUnitOfWork(DbConnection cntxDbConnect)
        {
            CntxDbConnect = cntxDbConnect;
        }

        /// <summary>
        /// Creates an instance using the repository
        /// </summary>
        /// <param name="repository"></param>
        public StudentSchoolChoicesUnitOfWork(IRepository repository)
        {
            Repository = repository;
            //Repositories.Add("ISchoolChoicesRepository", Repository);
            AddRepository(typeof(SchoolChoiceRepository));
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
                    Context.Dispose();

            _disposed = true;
        }

        #endregion

        #region " Commented code - can be used later"

        /// <summary>
        /// Adds the repositories to the read only collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        //public IRepository AddRepository<T>() where T : class
        //{
        //    if (Repositories == null)
        //        Repositories = new Hashtable();

        //    var type = typeof(T).Name;

        //    if (Repositories.ContainsKey(type)) return (IRepository) Repositories[type];
        //    var repositoryType = typeof(IRepository);

        //    var repositoryInstance =
        //        Activator.CreateInstance(repositoryType
        //            .MakeGenericType(typeof(T)), Context);

        //    Repositories.Add(type, repositoryInstance);

        //    return (IRepository)Repositories[type];
        //}

        /// <summary>
        /// Adds the Unit of work to the read only collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
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
