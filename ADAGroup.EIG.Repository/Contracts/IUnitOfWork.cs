using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Contracts
{
    public interface IUnitOfWork
    {
        IEIGRepository EIGRepo { get; }
        IEventRepository EventRepo { get; }

        void Commit();

        void Rollback();
    }
}
