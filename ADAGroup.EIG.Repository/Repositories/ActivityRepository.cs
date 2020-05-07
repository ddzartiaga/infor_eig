using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Repositories
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
