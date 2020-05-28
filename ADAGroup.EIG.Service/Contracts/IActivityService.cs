using ADAGroup.EIG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Service.Contracts
{
    public interface IActivityService
    {
        List<ActivityForList> GetActivities();

        void UpsertActivity();

        void RemoveActivity();
    }
}
