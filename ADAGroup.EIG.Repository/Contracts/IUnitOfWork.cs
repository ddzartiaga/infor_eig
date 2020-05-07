using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Contracts
{
    public interface IUnitOfWork
    {
        IEIGRepository EIGRepo { get; }
        IActivityRepository ActivityRepo { get; }

        void Commit();

        void Rollback();
    }
}
