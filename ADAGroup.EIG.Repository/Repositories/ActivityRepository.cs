using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ADAGroup.EIG.Repository.Repositories
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(DatabaseContext dbContext) : base(dbContext)
        {
            
        }

        public List<Activity> GetAllIncludingParent()
        {
            return _entities.Include(e => e.Group).ToList();
        }
    }
}
