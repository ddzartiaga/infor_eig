using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class ImageAsset : BaseEntity
    {
        public String Label { get; set; }

        public string Content { get; set; }

        public string Location { get; set; }

        public string FileType { get; set; }

        public string Classification { get; set; }

        public Guid GroupId { get; set; }
        public InterestGroup Group { get; set; }
    }
}
