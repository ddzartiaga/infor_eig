using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
