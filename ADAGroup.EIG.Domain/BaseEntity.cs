using ADAGroup.EIG.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? DateModified { get; set; }

        public string ModifiedBy { get; set; }
    }
}
