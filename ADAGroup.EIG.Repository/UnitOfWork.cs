using ADAGroup.EIG.Repository.Contracts;
using ADAGroup.EIG.Repository.Repositories;
using System;

namespace ADAGroup.EIG.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;
        private IEIGRepository _eigRepo;
        private IEventRepository _eventRepo;

        public UnitOfWork(DatabaseContext dbContext)
        {
            _databaseContext = dbContext;
        }


        public IEIGRepository EIGRepo => _eigRepo ?? new EIGRepository(_databaseContext);

        public IEventRepository EventRepo => _eventRepo ?? new EventRepository(_databaseContext);

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
