using ADAGroup.EIG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class EventEntityTypeConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> orderConfiguration)
        {

        }
    }
}
