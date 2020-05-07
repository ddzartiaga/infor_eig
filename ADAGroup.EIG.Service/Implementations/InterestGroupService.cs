using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Repository.Contracts;
using ADAGroup.EIG.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Service.Implementations
{
    public class InterestGroupService : IInterestGroupService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InterestGroupService(IUnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        public void UpsertInterestGroup()
        {
            try
            {
                InterestGroup group = new InterestGroup()
                {
                    Name = "Sample",
                    DateCreated = DateTime.Now,
                    Officers = new List<Officer>() {
                        new Officer()
                        {
                            Name = "Dudz", Designation = "Tanod", DateCreated = DateTime.Now
                        }
                    },
                };

                _unitOfWork.EIGRepo.Add(group);
                _unitOfWork.Commit();
            } 
            catch(Exception ex)
            {

            }
            
        }

        public void SetStatus()
        {
            throw new NotImplementedException();
        }

        
    }
}
