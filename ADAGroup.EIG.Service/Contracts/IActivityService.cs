using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Service.Contracts
{
    public interface IActivityService
    {
        void UpsertActivity();

        void RemoveActivity();
    }
}
