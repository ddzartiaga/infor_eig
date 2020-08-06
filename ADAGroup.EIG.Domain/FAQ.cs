using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Domain
{
    public class FAQ : BaseEntity
    {
        public Guid RefId { get; set; }

        public string EntityType { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
