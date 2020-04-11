using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ADAGroup.EIG.Domain;

namespace ADAGroup.EIG.Repository.Configurations
{
    public class EIGEntityTypeConfiguration : IEntityTypeConfiguration<EIGroup>
    {
        public void Configure(EntityTypeBuilder<EIGroup> config)
        {
            config.HasKey(c => c.Id);

            config.Property(c => c.Id).ValueGeneratedOnAdd();
            config.Property(c => c.Name).IsRequired();
            config.Property(c => c.DateCreated).ValueGeneratedOnAdd();
            config.Property(c => c.CreatedBy).IsRequired();
            config.Property(c => c.DateModified).ValueGeneratedOnUpdate();
        }
    }
}
