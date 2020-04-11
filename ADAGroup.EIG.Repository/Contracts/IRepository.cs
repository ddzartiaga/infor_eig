using ADAGroup.EIG.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ADAGroup.EIG.Repository.Contracts
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable GetAll();
        T Get(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
