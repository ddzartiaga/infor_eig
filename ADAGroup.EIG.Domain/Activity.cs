using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class Activity : BaseEntity
    {
        public string Title { get; set; }

        public string Details { get; set; }

        public string Location { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public string ContactName { get; set; }

        public string ContactInfo { get; set; }

        public Guid GroupId { get; set; }
        public InterestGroup Group { get; set; }
    }
}
