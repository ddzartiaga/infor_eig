using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Host { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }
    }
}
