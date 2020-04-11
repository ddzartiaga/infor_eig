using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain.Contracts
{
    public interface IEntity
    {
        Guid Id { get; set; }

        DateTime DateCreated { get; set; }

        string  CreatedBy { get; set; }

        DateTime? DateModified { get; set; }

        string ModifiedBy { get; set; }
    }
}
