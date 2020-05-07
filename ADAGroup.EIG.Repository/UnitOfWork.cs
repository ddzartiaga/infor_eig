using ADAGroup.EIG.Repository.Contracts;
using ADAGroup.EIG.Repository.Repositories;
using System;

namespace ADAGroup.EIG.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;
        private IEIGRepository _eigRepo;
        private IActivityRepository _activityRepo;

        public UnitOfWork(DatabaseContext dbContext)
        {
            _databaseContext = dbContext;
        }


        public IEIGRepository EIGRepo => _eigRepo ?? new EIGRepository(_databaseContext);

        public IActivityRepository ActivityRepo => _activityRepo ?? new ActivityRepository(_databaseContext);

        public void Commit()
        {
            _databaseContext.SaveChanges();
        }

        public void Rollback()
        {
            _databaseContext.Dispose();
        }
    }
}
