using ADAGroup.EIG.Repository.Contracts;
using ADAGroup.EIG.Repository.Repositories;
using System;

namespace ADAGroup.EIG.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;
        public IEIGRepository EIGRepo { get; }
        public IActivityRepository ActivityRepo { get; }

        public UnitOfWork(DatabaseContext dbContext)
        {
            _databaseContext = dbContext;
            EIGRepo = new EIGRepository(_databaseContext);
            ActivityRepo = new ActivityRepository(_databaseContext);
        }

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
