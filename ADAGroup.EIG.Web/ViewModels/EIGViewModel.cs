using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADAGroup.EIG.Web.ViewModels
{
    public class EIGViewModel
    {
        public string GroupId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Mission { get; set; }

        public string Vision { get; set; }

        public string About { get; set; }

        [Required]
        public string ContactPerson { get; set; }
    }
}
