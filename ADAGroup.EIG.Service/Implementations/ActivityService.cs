using ADAGroup.EIG.Domain;
using ADAGroup.EIG.Repository.Contracts;
using ADAGroup.EIG.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<ActivityForList> GetActivities()
        {
            try
            {
                var activities = new List<ActivityForList>();
                var list = _unitOfWork.ActivityRepo.GetAllIncludingParent();
                
                list.ForEach(a => activities.Add(new ActivityForList()
                {
                    EventId = a.Id.ToString(),
                    EventName = a.Title,
                    Start = a.StartDateTime.ToString("mm/dd/YYYY"),
                    End = a.StartDateTime.ToString("mm/dd/YYYY"),
                    GroupId = a.GroupId.ToString(),
                    GroupName = a.Group.Name,
                    Attendees = 0,
                }));

                return activities;
            }
            catch (Exception ex)
            {
                return new List<ActivityForList>();
            }
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
