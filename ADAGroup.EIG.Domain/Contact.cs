using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }

        public string Designation { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public Guid GroupId { get; set; }

        public InterestGroup Group { get; set; }
    }
}
