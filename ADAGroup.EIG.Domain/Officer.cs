using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class Officer : BaseEntity
    {
        public string Name { get; set; }

        public string Designation { get; set; }

        public bool IsContactPerson { get; set; }

        public Guid GroupId { get; set; }
        public InterestGroup Group { get; set; }
    }
}
