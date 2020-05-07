using ADAGroup.EIG.Repository.Contracts;
using ADAGroup.EIG.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Service.Implementations
{
    public class ActivityService : IActivityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActivityService(IUnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        public void RemoveActivity()
        {
            throw new NotImplementedException();
        }

        public void UpsertActivity()
        {
            throw new NotImplementedException();
        }
    }
}
