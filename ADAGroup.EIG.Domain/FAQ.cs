using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class FAQ : BaseEntity
    {
        public Guid RefId { get; set; }

        public string Type { get; set; }

        public string Label { get; set; }

        public string Content { get; set; }
    }
}
