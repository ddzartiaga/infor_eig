using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Repository.Contracts;
using ADAGroup.EIG.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Repositories
{
    public class EIGRepository : BaseRepository<EIGroup>, IEIGRepository
    {
        public EIGRepository(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
