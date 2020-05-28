using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class ActivityForList
    {
        public string EventId { get; set; }

        public string EventName { get; set; }

        public string GroupId { get; set; }

        public string GroupName { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public int Attendees { get; set; }
    }
}
