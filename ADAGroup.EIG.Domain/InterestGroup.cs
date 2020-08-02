using System;
using System.Collections.Generic;

namespace ADAGroup.EIG.Domain
{
    public class InterestGroup : BaseEntity
    {
        public string Name { get; set; }

        public string GoalAndPurpose { get; set; }

        public string Mission { get; set; }

        public ICollection<FAQ> FAQs { get; set; }

        public ICollection<Activity> Activities { get; set; }

        public ICollection<Image> Images { get; set; }

    }
}
