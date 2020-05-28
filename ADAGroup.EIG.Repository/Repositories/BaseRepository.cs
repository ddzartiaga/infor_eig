using ADAGroup.EIG.Domain.Contracts;
using ADAGroup.EIG.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAGroup.EIG.Repository.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DatabaseContext _dbContext;
        protected DbSet<T> _entities;

        public BaseRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T Get(Guid id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("'entity' parameter is null");

            _entities.Add(entity);
        }

        public void Delete(Guid id)
        {
            if (id == null)
                throw new ArgumentNullException("'entity id' parameter is null");

            T entity = Get(id);
            _entities.Remove(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("'entity' parameter is null");

            _entities.Update(entity);
        }
    }
}
