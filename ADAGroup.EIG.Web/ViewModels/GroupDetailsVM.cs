using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADAGroup.EIG.Web.ViewModels
{
    public class GroupDetailsVM
    {
        public string GroupId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string GoalAndPurpose { get; set; }

        [Required]
        public string Mission { get; set; }

        [Required]
        public string Requirements { get; set; }
        
        public string Logo { get; set; }
    }
}
