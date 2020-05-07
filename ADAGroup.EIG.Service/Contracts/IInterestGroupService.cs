using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Service.Contracts
{
    public interface IInterestGroupService
    {
        void UpsertInterestGroup();

        void SetStatus();
    }
}
