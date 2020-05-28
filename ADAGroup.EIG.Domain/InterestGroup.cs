using System;
using System.Collections.Generic;

namespace ADAGroup.EIG.Domain
{
    public class InterestGroup : BaseEntity
    {
        public string Name { get; set; }

        public string Logo { get; set; }

        public string GoalAndPurpose { get; set; }

        public string Mission { get; set; }

        public string Requirements { get; set; }

        public ICollection<Contact> Contacts {get;set;}

        public ICollection<Activity> Activities { get; set; }

        public ICollection<ImageAsset> Images { get; set; }

    }
}
