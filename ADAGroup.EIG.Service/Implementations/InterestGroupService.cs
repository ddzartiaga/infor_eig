using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Repository.Contracts;
using ADAGroup.EIG.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ADAGroup.EIG.Service.Implementations
{
    public class InterestGroupService : IInterestGroupService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InterestGroupService(IUnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        public List<InterestGroup> GetInterestGroups()
        {
            try
            {
                return _unitOfWork.EIGRepo.GetAll().ToList();
            } 
            catch (Exception ex)
            {
                return new List<InterestGroup>();
            }
        }

        public void UpsertInterestGroup(InterestGroup group)
        {
            try
            {
                if(group.Id == Guid.Empty)
                {
                    // Insert new record
                    group.DateCreated = DateTime.UtcNow;
                    _unitOfWork.EIGRepo.Add(group);
                }
                else
                {
                    group.DateModified = DateTime.UtcNow;
                    _unitOfWork.EIGRepo.Update(group);
                }
                
                _unitOfWork.Commit();
            } 
            catch(Exception ex)
            {
                // TODO: Log error
            }
            
        }

        public void SetStatus()
        {
            throw new NotImplementedException();
        }

        
    }
}
