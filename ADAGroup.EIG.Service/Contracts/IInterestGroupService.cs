using ADAGroup.EIG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Service.Contracts
{
    public interface IInterestGroupService
    {
        List<GroupShortInfo> GetGroupsShortInfo();

        InterestGroup GetGroupDetails(string groupId);

        List<InterestGroup> GetInterestGroups();

        void UpsertInterestGroup(InterestGroup group);

        void SetStatus();
    }
}
