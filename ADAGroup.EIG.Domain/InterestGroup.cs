using System;
using System.Collections.Generic;

namespace ADAGroup.EIG.Domain
{
    public class InterestGroup : BaseEntity
    {
        public string Name { get; set; }

        public string Mission { get; set; }

        public string Vision { get; set; }

        public ICollection<Officer> Officers { get; set; }

        public ICollection<Activity> Activities { get; set; }

        public ICollection<ImageAsset> Images { get; set; }

    }
}
