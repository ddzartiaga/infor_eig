using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class Image : BaseEntity
    {
        public Guid RefId { get; set; }

        public String Label { get; set; }

        public string Content { get; set; }

        public string Location { get; set; }

        public string FileType { get; set; }

        public string ImageType { get; set; }
    }
}
